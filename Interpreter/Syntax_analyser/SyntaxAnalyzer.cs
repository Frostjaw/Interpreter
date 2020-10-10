using System;
using System.Collections.Generic;
using Interpreter.Exceptions;
using Interpreter.LexicalAnalysis;

namespace Interpreter.SyntaxAnalysis
{
    internal partial class Syntax_analyzer
    {

        public enum Non_terminal
        {
            Start,
            Declarations,
            Last_declaration,
            Declaration_type,
            Array_decl,
            Var,
            Array_var,
            Bool,
            New_bool,
            Statements,
            Statement,
            Else_statement,
            And_expr,
            New_and_expr,
            Expr,
            New_expr,
            Unary,
            Comparison,
            Term,
            New_term,
        }

        public enum Action_type
        {
            Plus,
            Minus,
            Mul,
            Div,
            Unar_plus,
            Unar_minus,
            Less,
            More,
            Equal,
            Less_or_equal,
            More_or_equal,
            Empty,
            Num,
            Id,
            Get,
            Index,
            Int_declaration,
            Array_declaration,
            Write,
            Read,
            Array_size,
            Get_name,
            Auxiliary_action_1,
            Auxiliary_action_2,
            Auxiliary_action_3,
            Auxiliary_action_4,
            Auxiliary_action_5,
        }

        private List<RPN_elem> rpn;
        private Dictionary<Non_terminal, Dictionary<Lexical_analyser.TYPE, Rule>> Table_of_rules;
        private Dictionary<Non_terminal, Dictionary<Lexical_analyser.TYPE, Action>> Table_of_actions;
        private int cur_lexeme; // Индекс текущей лексемы

        public Syntax_analyzer()
        {
            Init_table_of_rules();
            Init_table_of_actions();
        }

        // ОПС для всей программы
        public List<RPN_elem> Parse(List<Lexeme> lexemes)
        {
            rpn = new List<RPN_elem>();

            Stack<int> label_stack = new Stack<int>();
            Stack<State> state_stack = new Stack<State>();
            Stack<Action_type> additional_stack = new Stack<Action_type>();

            state_stack.Push(new State(Lexical_analyser.TYPE.Eof));
            state_stack.Push(new State(Non_terminal.Start));

            additional_stack.Push(Action_type.Empty);
            additional_stack.Push(Action_type.Empty);

            Stack<int> array_size_stack = new Stack<int>();

            String my_name = "";

            cur_lexeme = 0;

            //Таблица переменных
            Dictionary<string, Data_type> Table_of_vars = new Dictionary<string, Data_type>();

            while (state_stack.Count > 0)
            {
                State Top_state = state_stack.Pop();
                Action_type Top_action = additional_stack.Pop();
                Lexeme cur_lex = lexemes[cur_lexeme];

                if (Top_action != Action_type.Empty)
                {
                    int i;
                    RPN_elem rpnElement = null;
                    switch (Top_action)
                    {
                        case Action_type.Get_name:
                            my_name = cur_lex.val;
                            break;
                        case Action_type.Int_declaration:
                            var newVariable = new Type_int_var();
                            Table_of_vars[my_name] = newVariable;
                            break;
                        case Action_type.Array_declaration:
                            var newArray = new Type_array(array_size_stack.Pop());
                            Table_of_vars[my_name] = newArray;
                            break;
                        case Action_type.Array_size:
                            array_size_stack.Push(int.Parse(cur_lex.val));
                            break;
                        case Action_type.Read:
                            rpnElement = new Read();
                            break;
                        case Action_type.Write:
                            rpnElement = new Write();
                            break;
                        case Action_type.Plus:
                            rpnElement = new Plus();
                            break;
                        case Action_type.Minus:
                            rpnElement = new Minus();
                            break;
                        case Action_type.Mul:
                            rpnElement = new Mul();
                            break;
                        case Action_type.Div:
                            rpnElement = new Div();
                            break;
                        case Action_type.Unar_plus:
                            rpnElement = new Unar_plus();
                            break;
                        case Action_type.Unar_minus:
                            rpnElement = new Unar_minus();
                            break;
                        case Action_type.Less:
                            rpnElement = new Less();
                            break;
                        case Action_type.Less_or_equal:
                            rpnElement = new Less_or_equal();
                            break;
                        case Action_type.More:
                            rpnElement = new More();
                            break;
                        case Action_type.More_or_equal:
                            rpnElement = new More_or_equal();
                            break;
                        case Action_type.Equal:
                            rpnElement = new Equal();
                            break;
                        case Action_type.Index:
                            rpnElement = new Index();
                            break;
                        case Action_type.Get:
                            rpnElement = new Get();
                            break;
                        case Action_type.Id:
                            if (Table_of_vars.ContainsKey(cur_lex.val))
                            {
                                rpnElement = new Put_data_type_to_stack(Table_of_vars[cur_lex.val]);
                            }
                            else
                            {
                                throw new Syntax_analyser_exception("Переменная не объявлена", cur_lex.line, cur_lex.char_pos);
                            }
                            break;
                        case Action_type.Num:
                            rpnElement = new Put_data_type_to_stack(new Type_number(int.Parse(cur_lex.val)));
                            break;
                        case Action_type.Auxiliary_action_1:
                            label_stack.Push(rpn.Count);
                            rpn.Add(new Put_data_type_to_stack(new Type_number()));
                            rpnElement = new Jf();
                            break;
                        case Action_type.Auxiliary_action_2:
                            i = label_stack.Pop();
                            rpn[i] = new Put_data_type_to_stack(new Type_number(rpn.Count + 2));
                            label_stack.Push(rpn.Count);
                            rpn.Add(new Put_data_type_to_stack(new Type_number(-1)));
                            rpnElement = new J();
                            break;
                        case Action_type.Auxiliary_action_3:
                            i = label_stack.Pop();
                            rpn[i] = new Put_data_type_to_stack(new Type_number(rpn.Count));
                            break;
                        case Action_type.Auxiliary_action_4:
                            label_stack.Push(rpn.Count);
                            break;
                        case Action_type.Auxiliary_action_5:
                            i = label_stack.Pop();
                            rpn[i] = new Put_data_type_to_stack(new Type_number(rpn.Count + 2));
                            i = label_stack.Pop();
                            rpn.Add(new Put_data_type_to_stack(new Type_number(i)));
                            rpn.Add(new J());
                            break;
                        default:
                            throw new Exception("Действие не выполнено");
                    }
                    if (rpnElement != null)
                    {
                        rpn.Add(rpnElement);
                    }
                }
                if (Top_state.Is_empty)
                {
                    continue;
                }

                if (Top_state.Is_terminal)
                {
                    //на вершине стека терминал
                    if (Top_state.Terminal == cur_lex.Type)
                        cur_lexeme++;
                    else
                        throw new Syntax_analyser_exception("Неожиданный символ " + cur_lex.Type.ToString(), cur_lex.line, cur_lex.char_pos);
                }
                else
                {
                    //на вершине стека нетерминал
                    Non_terminal nt = Top_state.Non_terminal;
                    if (!Table_of_rules.ContainsKey(nt) || !Table_of_rules[nt].ContainsKey(cur_lex.Type))
                    {
                        throw new Syntax_analyser_exception("Неожиданный символ ", cur_lex.line, cur_lex.char_pos);
                    }
                    Table_of_rules[nt][cur_lex.Type].Apply(state_stack);
                    Table_of_actions[nt][cur_lex.Type].Apply(additional_stack);
                }
            }
            return rpn;
        }
    }
}