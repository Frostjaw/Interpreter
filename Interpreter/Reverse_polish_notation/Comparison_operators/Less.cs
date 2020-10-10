using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Less : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            int right, left;
            right = execution_stack.Pop().Get_int_val();
            left = execution_stack.Pop().Get_int_val();
            if (left < right)
            {
                execution_stack.Push(new Type_bool(true));
            }
            else
            {
                execution_stack.Push(new Type_bool(false));
            }
        }
    }
}