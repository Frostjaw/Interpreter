using System.Collections.Generic;
using Interpreter.SyntaxAnalysis;

namespace Interpreter
{
    internal class Action
    {
        private readonly List<Syntax_analyzer.Action_type> actions;
        public bool Is_empty;

        public Action()
        {
            Is_empty = true;
        }

        public Action(List<Syntax_analyzer.Action_type> actions)
        {
            Is_empty = false;
            this.actions = actions;
        }

        public void Apply(Stack<Syntax_analyzer.Action_type> additional_stack)
        {
            if (Is_empty)
            {
                return;
            }
            for (int i = actions.Count - 1; i >= 0; i--)
            {
                additional_stack.Push(actions[i]);
            }
        }
    }
}