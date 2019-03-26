using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputer laptop = new ConcreteLaptop();
            ComputerDecorator gamingDecorator = new GamingDecorator(laptop);

            IComputer desktop = new ConcreteDesktop();
            ComputerDecorator officeDecorator = new OfficeDecorator(desktop);

            foreach (var item in gamingDecorator.GetComponents())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Cost: {gamingDecorator.GetCost()}");

            foreach (var item in officeDecorator.GetComponents())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Cost: {officeDecorator.GetCost()}");


            Console.ReadKey();
        }
    }
}
