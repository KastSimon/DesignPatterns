using System;
using DesignPatterns.State;

namespace StatePattern
{
    

    class Program
    {
        static Context saleState = new Context(new StateAvailable());

        static void Main(string[] args)
        {
            StatePatternDemo();
        }

        static void StatePatternDemo()
        {
            saleState.Sold(); //Transition to StSold

            saleState.Available(); //Transition to StAvailable

            Console.ReadLine();
        }
    }
}
