using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {

            Metot metot = new Metot();
            //int sayi;
            //Console.WriteLine(metot.KaresiniAl(ref sayi));//out olursa çalışıyor
            //Console.WriteLine(sayi);

           
            Console.WriteLine(Metot.Topla(1, 2));
            Console.WriteLine(Metot.Topla(1, 2, 3));
            Console.WriteLine(Metot.Topla(1.0, 2.0));
            Console.WriteLine(Metot.Topla(1, 2, 4, 5));
            Console.ReadLine();

        }
    }
}
