using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_AbstractFabric
{
    public class Smartphone : ISmartphone
    {
        public string Name
        {
            get; private set;
        }

        public Smartphone(string name)
        {
            Name = name;
        }
    }
}
