using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Type_bool : Data_type
    {
        private bool val;

        public Type_bool()
        {
            val = false;
        }

        public Type_bool(bool value)
        {
            val = value;
        }

        public override bool Get_bool_val()
        {
            return val;
        }

        public override void Set_bool_val(bool value)
        {
            val = value;
        }
    }
}
