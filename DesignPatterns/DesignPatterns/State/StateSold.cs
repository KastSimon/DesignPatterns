using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    class StateSold :State
    {
       

        public override void Available()
        {
            Console.WriteLine("StSold handles available.");
            Console.WriteLine("StSold wants to change the state of the context.");
            this.context.TransitionTo(new StateAvailable());
        }

        public override void Sold()
        {
            Console.WriteLine("StSold handles sold.");
        }
    }
}
