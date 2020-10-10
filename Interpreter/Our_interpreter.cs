using System;
using System.Collections.Generic;
using System.IO;
using Interpreter.Exceptions;
using Interpreter.LexicalAnalysis;
using Interpreter.SyntaxAnalysis;

namespace Interpreter
{
    class Our_interpreter
    {
        private Lexical_analyser Lex_analyser;
        private Syntax_analyzer Syntax_analyser;

        public Our_interpreter()
        {
            Lex_analyser = new Lexical_analyser();
            Syntax_analyser = new Syntax_analyzer();
        }

        public void Interprete(string file_path, TextReader input, TextWriter output)
        {
            string src_code = (new StreamReader(file_path)).ReadToEnd();
            List<Lexeme> lexemes = Lex_analyser.Get_lexemes(src_code);
            List<RPN_elem> rpn = Syntax_analyser.Parse(lexemes);

            var execution_stack = new Stack<Data_type>();

            int i = 0;
            while (i < rpn.Count)
            {
                rpn[i].Execute(execution_stack, ref i, output, input);
                i++;
            }
        }
    }
}
