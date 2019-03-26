using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDecoratorPattern
{
    interface IComputer
    {
        List<string> GetComponents();
        float GetCost();
    }
}
