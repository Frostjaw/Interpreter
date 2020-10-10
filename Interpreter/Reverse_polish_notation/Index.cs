using System;
using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Index : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            int index = execution_stack.Pop().Get_int_val();
            Data_type variable = execution_stack.Pop().Get_data_type_at_index(index);
            execution_stack.Push(variable);
        }
    }
}