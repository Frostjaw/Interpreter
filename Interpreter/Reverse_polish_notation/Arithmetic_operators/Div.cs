using System;
using System.Collections.Generic;
using System.IO;
using Interpreter.Exceptions;

namespace Interpreter
{
    internal class Div : RPN_elem
    {
        public override void Execute(Stack<Data_type> execution_stack, ref int cursorPosition, TextWriter text_output, TextReader text_input)
        {
            int right, left;
            right = execution_stack.Pop().Get_int_val();
            left = execution_stack.Pop().Get_int_val();
            if (right == 0)
            {
                throw new Our_runtime_exception("Деление на 0");
            }
            execution_stack.Push(new Type_number(left / right));
        }
    }
}