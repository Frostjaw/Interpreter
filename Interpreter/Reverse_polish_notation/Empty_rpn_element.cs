using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Empty_rpn_element : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
        }
    }
}