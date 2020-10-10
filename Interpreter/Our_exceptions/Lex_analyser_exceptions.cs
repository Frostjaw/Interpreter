using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Exceptions
{
    class Lex_analyser_exception : Exception
    {
        public int line;
        public int col;

        public Lex_analyser_exception(string msg, int line, int col)
            : base(msg)
        {
            this.line = line;
            this.col = col;
            Console.WriteLine("Error: at line:{0}, № of symbol:{1}", line, col - 1); // Бросает исключение на следующем символе
        }
    }
}
