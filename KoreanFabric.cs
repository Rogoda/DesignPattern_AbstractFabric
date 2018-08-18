using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_AbstractFabric
{
    public class KoreanFabric : IRtvFabric
    {
        public INotebook CraeteNotebook()
        {
            return new Notebook("Notebook from korean fabric");
        }

        public ISmartphone CraeteSmartphone()
        {
            return new Smartphone("Smartphone from korean fabric");
        }
    }
}
