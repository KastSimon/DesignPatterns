using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    class StateAvailable :State
    {
        public override void Available()
        {
            Console.Write("ConcreteStateB handles request1.");
        }

        public override void Sold()
        {
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
            this.context.TransitionTo(new StateSold());
        }
    }
}
