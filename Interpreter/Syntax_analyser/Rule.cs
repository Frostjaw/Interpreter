using System.Collections.Generic;

namespace Interpreter
{
    internal class Rule
    {
        private readonly bool is_empty;
        private readonly List<State> to_stack;

        public Rule()
        {
            is_empty = true;
        }

        public Rule(List<State> To_stack)
        {
            is_empty = false;
            to_stack = To_stack;
        }

        public void Apply(Stack<State> state_stack)
        {
            if (is_empty)
            {
                return;
            }
            for (int i = to_stack.Count - 1; i >= 0; i--)
            {
                state_stack.Push(to_stack[i]);
            }
        }
    }
}