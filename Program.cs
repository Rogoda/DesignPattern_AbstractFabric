using System;

namespace DesignPattern_AbstractFabric
{
    class Program
    {
        static void Main(string[] args)
        {
            IRtvFabric fabric1 = new ChineseFabric();
            IRtvFabric fabric2 = new KoreanFabric();

            var smartphone1 = fabric1.CraeteSmartphone();
            var notebook1 = fabric1.CraeteNotebook();

            var smartphone2 = fabric2.CraeteSmartphone();
            var notebook2 = fabric2.CraeteNotebook();

            Console.WriteLine(
                "\nYou have got one \n{0} and one \n{1}\n",
                smartphone1.Name,
                notebook1.Name);

            Console.WriteLine(
                "\nYou have got one \n{0} and one \n{1}\n",
                smartphone2.Name,
                notebook2.Name);
        }
    }
}
