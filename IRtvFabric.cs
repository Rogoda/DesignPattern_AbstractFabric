using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_AbstractFabric
{
    public interface IRtvFabric
    {
        INotebook CraeteNotebook();
        ISmartphone CraeteSmartphone();
    }
}
