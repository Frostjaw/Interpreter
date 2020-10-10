using System;
using System.Collections.Generic;
using Interpreter.Exceptions;

namespace Interpreter.LexicalAnalysis
{
    internal class Lexical_analyser
    {
        // Лексемы
        public enum TYPE
        {
            Id, // идентификатор
            Num, // целое число
            If, Else, While, Read, Write, Int, Do, End, // ключевые слова
            Left_round_bracket, // ( 
            Right_round_bracket, // )
            Left_square_bracket, // [
            Right_square_bracket, // ]
            Less, // <
            More, // >
            Equal, // ==
            Less_or_equal, // <=
            Greater_or_equal, // >=
            Get, // =
            Plus, Minus, Divide, Multiply,
            Semicolon, // ;
            Eof,
        };

        // Поля данных
        private String src_code; // исходный текст
        private Action<Lexical_analyser>[] sem_programs; // семантические программы
        private Dictionary<LexerType, Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>> conversion_table; // таблица переходов
        private HashSet<char> skip_chars; // символы для пропуска
        private Dictionary<char, TYPE> symbols; // символы языка
        private Dictionary<string, TYPE> key_words; // ключевые слова языка
        private TYPE lex_type; // тип распознанной лексемы
        private string str_val; // строка, накапливающая символы
        private LexerType cur_Type; // текущий тип для автоматной грамматики лексического анализатора
        private char last_char; // последний прочитанный символ
        private List<Lexeme> lexemes; // распознанные лексемы
        private int char_count; // количество прочитанных сиволов
        private int cur_line; // текущая строка
        private int cur_col; // текущий символ строки
        private int last_lex_start_line_pos; // положение начала лексемы (строка) 
        private int last_lex_start_col_pos; // положение начала лексемы (символ) 

        // Строки грамматики лексического анализатора
        public enum LexerType
        {
            S, D, Error, Num, Less, Equal, More, Id
        };

        // Столбцы грамматики лексического анализатора
        public enum CharType
        {
            Character, Numeric, Less, Equal, More, Symbol, Non_lang_symb, Skip, Eof
        };

        // Конструктор
        public Lexical_analyser()
        {
            Init_semantic_programs();
            Init_key_words();
            Init_symbols();
            Init_skip_chars();
            Init_conversion_table();
        }

        // Cемантические программы
        private void Init_semantic_programs()
        {
            sem_programs = new Action<Lexical_analyser>[]
                                    {
                                        // 0 Начало идентификатора
                                        l => 
                                            { 
                                                l.str_val = l.last_char.ToString();
                                                l.last_lex_start_line_pos = l.cur_line;
                                                l.last_lex_start_col_pos = l.cur_col-1;
                                            },

                                        // 1 Продолжение идентификатора
                                        l => { l.str_val += l.last_char.ToString(); },

                                        // 2 Пропуск
                                        l => 
                                        { 
                                            if(l.last_char == '\n')
                                            {
                                                l.cur_line++;
                                                l.cur_col = 1;
                                            }
                                            else
                                            {
                                                if (l.last_char == '=')                            
                                                    l.str_val += l.last_char.ToString();              
                                                l.last_lex_start_line_pos = l.cur_line;
                                                l.last_lex_start_col_pos = l.cur_col; 
                                            }
                                        },

                                        // 3 Распознан символ языка
                                        l => 
                                            {
                                                l.str_val += l.last_char.ToString();              
                                                l.lex_type = symbols[l.last_char];
                                                l.last_lex_start_line_pos = l.cur_line;
                                                l.last_lex_start_col_pos = l.cur_col-1; 
                                            },

                                        // 4 Распознан идентификатор или ключевое слово
                                        l =>
                                            {
                                                l.lex_type = key_words.ContainsKey(l.str_val) ? key_words[l.str_val] : TYPE.Id;
                                                l.char_count--;
                                                l.cur_col--;
                                            },

                                        // 5 Распознано число
                                        l =>
                                            {
                                                l.lex_type = TYPE.Num;
                                                l.char_count--;
                                                l.cur_col--;
                                            },

                                        // 6 Распознан <
                                        l =>
                                            {
                                                l.str_val += l.last_char.ToString();           
                                                l.lex_type = TYPE.Less;
                                                l.char_count--;
                                                l.cur_col--;
												l.last_lex_start_line_pos = l.cur_line;
                                                l.last_lex_start_col_pos = l.cur_col-1; 
                                            },

                                        // 7 Распознан <=
                                        l =>
                                        	{
                                                l.str_val += l.last_char.ToString();        
                                        		l.lex_type = TYPE.Less_or_equal;
												l.last_lex_start_line_pos = l.cur_line;
                                                l.last_lex_start_col_pos = l.cur_col-2; 
                                        	},

                                        // 8 Распознан =
                                        l =>
                                            {
                                                l.lex_type = TYPE.Get;
                                                l.char_count--;
                                                l.cur_col--;
												l.last_lex_start_line_pos = l.cur_line;
                                                l.last_lex_start_col_pos = l.cur_col-1; 
                                            },

                                        // 9 Распознан ==
                                        l =>
                                        	{
                                                l.str_val += l.last_char.ToString();      
                                        		l.lex_type = TYPE.Equal;
												l.last_lex_start_line_pos = l.cur_line;
												l.last_lex_start_col_pos = l.cur_col-2;
                                        	},

                                        // 10 Распознан >
                                        l =>
                                            {
                                                l.str_val += l.last_char.ToString();       
                                                l.lex_type = TYPE.More;
                                                l.char_count--;
                                                l.cur_col--;
												l.last_lex_start_line_pos = l.cur_line;
                                                l.last_lex_start_col_pos = l.cur_col-1; 
                                            },

                                        // 11 Распознан >=
                                        l =>
                                        	{
                                                l.str_val += l.last_char.ToString();         
                                        		l.lex_type = TYPE.Greater_or_equal;
												l.last_lex_start_line_pos = l.cur_line;
												l.last_lex_start_col_pos = l.cur_col-2;
                                        	},

                                        // 12 EoF
                                        l => { l.lex_type = TYPE.Eof; },

                                        // 13 Не цифровой символ внутри числа
                                        l =>
                                            {
                                                throw new Lex_analyser_exception("Не цифровой символ внутри числа",cur_line,cur_col);
                                            },

                                        // 14 Символа нет в языке
                                        l =>
                                            {
												throw new Lex_analyser_exception("Символа нет в языке",cur_line,cur_col);
                                            },
                                    };
        }

        //Kлючевые слова языка
        private void Init_key_words()
        {
            key_words = new Dictionary<string, TYPE>
                         {
                             {"if", TYPE.If},
                             {"else", TYPE.Else},
                             {"while", TYPE.While},
                             {"read", TYPE.Read},
                             {"write", TYPE.Write},
                             {"int", TYPE.Int},
                             {"do", TYPE.Do},
                             {"end", TYPE.End}
                         };
        }

        //Символы языка
        private void Init_symbols()
        {
            symbols = new Dictionary<char, TYPE>
                           {
                               {'+', TYPE.Plus},
                               {'-', TYPE.Minus},
                               {'/', TYPE.Divide},
                               {'*', TYPE.Multiply},
                               {'(', TYPE.Left_round_bracket},
                               {')', TYPE.Right_round_bracket},
                               {'[', TYPE.Left_square_bracket},
                               {']', TYPE.Right_square_bracket},
                               {';', TYPE.Semicolon},
                           };
        }

        //Символы для пропуска
        private void Init_skip_chars()
        {
            skip_chars = new HashSet<char> { ' ', '\n', '\t', '\r' };
        }

        //Таблица переходов
        private void Init_conversion_table()
        {
            conversion_table = new Dictionary<LexerType, Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>>();

            // S
            conversion_table[LexerType.S] = new Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>
        	{
                {CharType.Character, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Id,sem_programs[0])},
                {CharType.Numeric, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Num,sem_programs[0])},
                {CharType.Less, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Less,sem_programs[2])},
                {CharType.Equal, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Equal,sem_programs[2])},
                {CharType.More, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.More,sem_programs[2])},
                {CharType.Skip, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.S,sem_programs[2])},
                {CharType.Symbol, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[3])},
                {CharType.Non_lang_symb, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Error,sem_programs[14])},
                {CharType.Eof, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[12])},
        	};

            // Id
            conversion_table[LexerType.Id] = new Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>
        	{
                {CharType.Character, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Id,sem_programs[1])},
                {CharType.Numeric, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Id,sem_programs[1])},
                {CharType.Less, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[4])},
                {CharType.Equal, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[4])},
                {CharType.More, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[4])},
                {CharType.Skip, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[4])},
                {CharType.Symbol, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[4])},
                {CharType.Non_lang_symb, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[4])},
                {CharType.Eof, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[4])},
        	};

            // Num
            conversion_table[LexerType.Num] = new Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>
        	{
                {CharType.Character, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Error,sem_programs[13])},
                {CharType.Numeric, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.Num,sem_programs[1])},
                {CharType.Less, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[5])},
                {CharType.Equal, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[5])},
                {CharType.More, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[5])},
                {CharType.Skip, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[5])},
                {CharType.Symbol, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[5])},
                {CharType.Non_lang_symb, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[5])},
                {CharType.Eof, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[5])},
        	};

            // Less
            conversion_table[LexerType.Less] = new Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>
        	{
                {CharType.Character, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
                {CharType.Numeric, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
                {CharType.Less, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
                {CharType.Equal, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[7])},
                {CharType.More, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
                {CharType.Skip, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
                {CharType.Symbol, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
                {CharType.Non_lang_symb, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
                {CharType.Eof, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[6])},
        	};

            // More
            conversion_table[LexerType.More] = new Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>
        	{
                {CharType.Character, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
                {CharType.Numeric, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
                {CharType.Less, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
                {CharType.Equal, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[11])},
                {CharType.More, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
                {CharType.Skip, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
                {CharType.Symbol, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
                {CharType.Non_lang_symb, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
                {CharType.Eof, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[10])},
        	};

            // Equal
            conversion_table[LexerType.Equal] = new Dictionary<CharType, Tuple<LexerType, Action<Lexical_analyser>>>
        	{
                {CharType.Character, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
                {CharType.Numeric, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
                {CharType.Less, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
                {CharType.Equal, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[9])},
                {CharType.More, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
                {CharType.Skip, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
                {CharType.Symbol, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
                {CharType.Non_lang_symb, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
                {CharType.Eof, new Tuple<LexerType, Action<Lexical_analyser>>(LexerType.D,sem_programs[8])},
        	};
        }

        //Обработать следущий символ
        private void Next_char()
        {
            CharType charType = CharType.Non_lang_symb;
            if (char_count >= src_code.Length)
                charType = CharType.Eof;
            else
            {
                char c = src_code[char_count];
                last_char = c;
                if (char.IsLetter(c))
                    charType = CharType.Character;
                if (char.IsNumber(c))
                    charType = CharType.Numeric;
                if (c == '<')
                    charType = CharType.Less;
                if (c == '=')
                    charType = CharType.Equal;
                if (c == '>')
                    charType = CharType.More;
                if (symbols.ContainsKey(c))
                    charType = CharType.Symbol;
                if (skip_chars.Contains(c))
                    charType = CharType.Skip;
            }
            char_count++;
            cur_col++;
            conversion_table[cur_Type][charType].Item2(this);
            cur_Type = conversion_table[cur_Type][charType].Item1;
        }

        //Получить следущую лексему
        private Lexeme Next_token()
        {
            var lex = new Lexeme();
            str_val = "";
            cur_Type = LexerType.S;
            while (cur_Type != LexerType.D)
            {
                Next_char();
            }
            lex.Type = lex_type;
            lex.val = str_val;
            lex.line = last_lex_start_line_pos;
            lex.char_pos = last_lex_start_col_pos;
            lexemes.Add(lex);
            return lex;
        }

        //Получить лексемы
        public List<Lexeme> Get_lexemes(string sourceCode)
        {
            char_count = 0;
            src_code = sourceCode;
            lexemes = new List<Lexeme>();
            cur_line = 1;
            cur_col = 1;
            Lexeme lexeme;
            do
            {
                lexeme = Next_token();
            } while (lexeme.Type != TYPE.Eof);
            return lexemes;
        }
    }
}
