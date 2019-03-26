using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDecoratorPattern
{
    abstract class ComputerDecorator : IComputer
    {
        private readonly IComputer _computer;

        public ComputerDecorator(IComputer computer)
        {
            _computer = computer;
        }


        public virtual List<string> GetComponents()
        {
            return _computer.GetComponents();
        }

        public virtual float GetCost()
        {
            return _computer.GetCost();
        }
    }
}
