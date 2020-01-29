using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class Reklama
    {
        public string Tresc;
        private TypOsoby typOsoby;
        private Zainteresowania Zainteresowania;

        public void Test()
        {
            if (typOsoby.HasFlag(TypOsoby.Dziecko))
            {
                Console.WriteLine("Reklama dla dzieci");
            }
            else if (typOsoby < TypOsoby.Dorosly)
            {
                Console.WriteLine("Reklama dla niepełnoletnich \n[nie mających 18 lat]\n");
            }

            for (int i = 0; i <= TypOsoby.Dziecko.SumaTypowOsob(); i++)
            {
                Console.Write($"{(TypOsoby)i}, ");
            }


        }

        public Reklama(string tresc, TypOsoby typOsoby, Zainteresowania zainteresowanie)
        {
            Tresc = tresc;
            this.typOsoby = typOsoby;
            Zainteresowania = zainteresowanie;
        }
    }
}
