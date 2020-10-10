using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Type_int_var : Type_number
    {
        public Type_int_var(int value)
            : base(value)
        { }

        public Type_int_var()
        { }

        public override void Set_int_value(int value)
        {
            val = value;
        }
    }
}
