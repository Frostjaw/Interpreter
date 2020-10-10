using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Get : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            int new_val = execution_stack.Pop().Get_int_val();
            Data_type left = execution_stack.Pop();
            left.Set_int_value(new_val);
        }
    }
}