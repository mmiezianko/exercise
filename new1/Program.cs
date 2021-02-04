using System;

namespace new1
{
    class Program
    {
        
        static void Main(string[] args)
        {
         
            Console.WriteLine("Hello World!");
            Plyta plyta1 = new Plyta("Sting", "shape", "2020-11-20", 23, Plyta.Kategoria.rock);
            Plyta plyta2 = new Plyta("The Clash", "london", "2020-04-05", 10, Plyta.Kategoria.metal);
            Plyta plyta3 = new Plyta("Bob Sincalir", "World", "2021-01-26", 44, Plyta.Kategoria.soul);
            Console.WriteLine(plyta1);


            Sklep sklep1 = new Sklep("abc", "123456789");
            sklep1.DodajPlyte(plyta1);
            sklep1.DodajPlyte(plyta2);
            sklep1.DodajPlyte(plyta3);
            Console.WriteLine(sklep1);

            Console.WriteLine(sklep1.SredniaCena());
           
        }
    }
}
