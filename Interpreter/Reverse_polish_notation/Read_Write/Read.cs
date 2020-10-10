using System;
using System.Collections.Generic;
using System.IO;
using Interpreter.Exceptions;

namespace Interpreter
{
    internal class Read : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursor_pos, TextWriter text_output, TextReader text_input)
        {
            Data_type var = execution_stack.Pop();
            int new_val = int.Parse(text_input.ReadLine());
            if (new_val == null)
            {
                throw new Our_runtime_exception("Введено не целое число");
            }
            var.Set_int_value(new_val);
        }
    }
}