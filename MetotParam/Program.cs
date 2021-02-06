using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotParam
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri() { FirstName = "Samed", LastName = "Musabaşoğlu", MusteriId = 1, TcKimlikNo = "237438929" };

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri1);
            Console.ReadLine();


        }
    }
}
