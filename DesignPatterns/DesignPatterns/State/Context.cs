using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class Context
    {
        // A reference to the current state of the Context.
        private State state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this.state = state;
            this.state.SetContext(this);
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Available()
        {
            this.state.Available();
        }

        public void Sold()
        {
            this.state.Sold();
        }
    }
}
