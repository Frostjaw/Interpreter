using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal abstract class RPN_elem
    {
        public abstract void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input);
    }
}