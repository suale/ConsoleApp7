using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotParam
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri Musteri)
        {
            Console.WriteLine("{0} isimli müşteri eklendi!", Musteri.FirstName);
        }
        public void MusteriSil(Musteri Musteri)
        {
            Console.WriteLine("{0} id no'lu müşteri silindi!", Musteri.MusteriId);
        }
        
    }
}
