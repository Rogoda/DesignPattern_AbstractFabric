using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_AbstractFabric
{
    public class Notebook : INotebook
    {
        public string Name
        {
            get; private set;
        }

        public Notebook(string name)
        {
            Name = name;
        }
    }
}
