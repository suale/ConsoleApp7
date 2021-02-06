using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Metot
    {
        //public int KaresiniAl(ref int a)
        //{
        //    a = 12;
        //    a = a * a;
        //    return a;
        //}

        public static int Topla(int a, int b)
        {
            return a + b;
        }

        public static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Topla(double a, double b)
        {
            return a * b;
        }

        public static int Topla(params int[] sayilar)
        {
            return sayilar.Length;
        }
    }
}
