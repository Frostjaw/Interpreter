using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Put_data_type_to_stack : RPN_elem
    {
        private Data_type Data_type_val;

        public Put_data_type_to_stack(Data_type data_type_val)
        {
            Data_type_val = data_type_val;
        }

        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            execution_stack.Push(Data_type_val);
        }
    }
}
