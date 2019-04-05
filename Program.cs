using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatrice c = new Calculatrice();
            Console.WriteLine(c.Addition(5,5));
            c.ChoixOperation(Choix.Addition);
            c.ChoixOperation(Choix.Soustraction);
            c.Add(4);
            c.Add(5);
            c.Add(3);
            Console.WriteLine(c.Calculer());
            Console.ReadLine();
        }
    }
}
