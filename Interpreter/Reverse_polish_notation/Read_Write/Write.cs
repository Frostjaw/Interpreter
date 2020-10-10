using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Write : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            Data_type var = execution_stack.Pop();
            text_output.Write("{0}\r\n", var.Get_int_val());
        }
    }
}