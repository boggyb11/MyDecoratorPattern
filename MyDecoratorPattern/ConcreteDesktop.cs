using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDecoratorPattern
{
    class ConcreteDesktop : IComputer
    {
        public List<string> GetComponents()
        {
            List<string> components = new List<string>();
            components.Add("HDD");
            components.Add("processor");
            components.Add("Power source");
            components.Add("RAM");
            components.Add("Disc Drive");

            return components;
        }

        public float GetCost()
        {
            return 650.0f;
        }
    }
}
