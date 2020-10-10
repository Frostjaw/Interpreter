using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Type_number : Data_type
    {
        protected int val;

        public Type_number()
        {
            val = 0;
        }

        public Type_number(int value)
        {
            val = value;
        }

        public override int Get_int_val()
        {
            return val;
        }
    }
}
