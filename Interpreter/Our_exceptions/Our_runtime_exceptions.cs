using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Interpreter.Exceptions
{
    class Our_runtime_exception : Exception
    {
        public Our_runtime_exception(string msg)
            : base(msg)
        {
        }

        public void Print_msg(TextWriter output_stream)
        {
            output_stream.WriteLine("Runtime Error:{0}", Message);
        }
    }
}
