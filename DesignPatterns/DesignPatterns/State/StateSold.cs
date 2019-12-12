using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class StateSold :State
    {
       

        public override void Available()
        {
            //Placeholder User Code..
            Console.WriteLine("StSold wants to change the state to available.");
            this.context.TransitionTo(new StateAvailable());
        }

        public override void Sold()
        {
            //Placeholder User Code..
            Console.WriteLine("StSold handles sold.");
        }
    }
}
