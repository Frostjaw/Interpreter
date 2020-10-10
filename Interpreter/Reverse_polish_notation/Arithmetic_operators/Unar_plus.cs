using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Unar_plus : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_position, TextWriter text_output, TextReader text_input)
        {
            execution_stack.Push(new Type_number(execution_stack.Pop().Get_int_val()));
        }
    }
}