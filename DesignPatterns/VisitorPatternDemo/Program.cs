using System;
using DesignPatterns.Visitor;

namespace VisitorPattern {
    class Program {
        static void Main(string[] args) {
            var x = new VisitorMain();
            x.Main();
            Console.ReadKey();
        }
    }
}
