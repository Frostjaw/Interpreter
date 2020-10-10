using System;
using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class J : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            cursor_pos = execution_stack.Pop().Get_int_val() - 1;
        }
    }
}