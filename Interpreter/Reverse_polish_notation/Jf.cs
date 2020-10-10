using System;
using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Jf : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            int index = execution_stack.Pop().Get_int_val();
            bool condition = execution_stack.Pop().Get_bool_val();
            if (!condition)
            {
                cursor_pos = index - 1;
            }
        }
    }
}