using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_AbstractFabric
{
    public class ChineseFabric : IRtvFabric
    {
        public INotebook CraeteNotebook()
        {
            return new Notebook("Notebook from chinese fabric");
        }

        public ISmartphone CraeteSmartphone()
        {
            return new Smartphone("Notebook from chinese fabric");
        }
    }
}
