using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDecoratorPattern
{
    class GamingDecorator : ComputerDecorator
    {
        public GamingDecorator(IComputer computer) : base(computer)
        {
        }

        public override List<string> GetComponents()
        {
            List<string> officeComponents = new List<string>();
            officeComponents.Add("Graphics Card");

            base.GetComponents().AddRange(officeComponents);

            return base.GetComponents();
        }

        public override float GetCost()
        {
            return base.GetCost() + 250.0f;
        }
    }
}
