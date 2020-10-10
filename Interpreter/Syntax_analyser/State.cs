using Interpreter.LexicalAnalysis;
using Interpreter.SyntaxAnalysis;

namespace Interpreter
{
    internal class State
    {
        private readonly Syntax_analyzer.Non_terminal non_terminal;
        private readonly Lexical_analyser.TYPE type;
        public bool Is_empty;
        public bool Is_terminal;

        public State()
        {
            Is_empty = true;
        }

        public State(Syntax_analyzer.Non_terminal nt)
        {
            Is_empty = false;
            Is_terminal = false;
            non_terminal = nt;
        }

        public State(Lexical_analyser.TYPE t)
        {
            Is_empty = false;
            Is_terminal = true;
            type = t;
        }

        public Lexical_analyser.TYPE Terminal
        {
            get { return type; }
        }

        public Syntax_analyzer.Non_terminal Non_terminal
        {
            get { return non_terminal; }
        }
    }
}