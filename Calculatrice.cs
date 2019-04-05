using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculatrice
{
    delegate int PrototypeOperation(int i, int j);
    enum Choix{Addition,Soustraction,multiplication,Division};
    class Calculatrice
    {
        PrototypeOperation dlgOperation;
        List<int> lesNombres;
        public Calculatrice()
        {
            lesNombres = new List<int>();
        }
        public void Add(int n)
        {
            lesNombres.Add(n);
        }

        public int Addition(int i, int j)
        {
            return i + j;
        }
        public int Calculer()
        {
            int cpt = 1;
            int resultat=lesNombres[0];
            foreach (PrototypeOperation d in dlgOperation.GetInvocationList())
            {
                resultat = d.Invoke(resultat, lesNombres[cpt]);
                cpt++;
            }
            return resultat;
        }
        public int Calculer(int n1, int n2)
        {
            this.Add(n1);
            this.Add(n2);
            return Calculer();
        }
        public void ChoixOperation(Choix choix)
        {
            switch (choix)
            {
                case Choix.Addition:
                    dlgOperation += Addition;
                    break;
                case Choix.Soustraction:
                    dlgOperation += Soustraction;
                    break;

            }
        }
        public int Soustraction(int i, int j)
        {
            return i - j;
        }
        public int Multiplication(int i, int j)
        {
            return i * j;
        }
        public int Division(int i, int j)
        {
            return i / j;
        }
    }
}
