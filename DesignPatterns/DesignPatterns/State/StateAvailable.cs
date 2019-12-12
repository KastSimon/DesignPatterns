using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class StateAvailable :State
    {
        public override void Available()
        {
            //Placeholder User Code..
            Console.Write("StAvailable handles available.");
        }

        public override void Sold()
        {
            //Placeholder User Code..
            Console.WriteLine("StAvailable wants to change the state to sold.");
            this.context.TransitionTo(new StateSold());
        }
    }
}
