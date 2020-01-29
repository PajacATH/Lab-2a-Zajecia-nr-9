using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Rozszerzenia
            
            //// Rozszerzenie int

            //Console.Write("Podaj liczbe: ");
            //int.TryParse(Console.ReadLine(), out int liczba);

            //(int wynik, int reszta) = liczba.Podziel(3);

            //Console.WriteLine($"{liczba} / 3 = {wynik}, reszta {reszta}\n");

            //// Rozszerzenie string

            //string text = "Ala ma kota a kot ma ale a nikt nie ma psa xD";

            //Console.Write("Podaj znak: ");
            //char.TryParse(Console.ReadLine(), out char znak);

            //Console.Write("Wielkość znaków ma znaczenie? \n[1] TAK \n[0] NIE\n");
            //int.TryParse(Console.ReadLine(), out int wielkosc);

            //Console.WriteLine($"W tekście \"{text}\" \nwystepuje {text.IleZnakow(znak, wielkosc)} znaków \"{znak}\"\n");
            
            #endregion

            Reklama reklama = new Reklama("Jakaś treść", TypOsoby.Dorosly & TypOsoby.Emeryt, Zainteresowania.Motoryzacja);
            reklama.Test();
        }
    }
}
