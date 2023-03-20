using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210125
{
    internal class penjumlahan<T>
    {
        private T a;
        private T b;
        private T c;
        public void jumlahTigaAngka(T a, T b ,T c)
        {
            dynamic hasil = 0;

            hasil = hasil + a;
            hasil = hasil + b;
            hasil = hasil + c;
            Console.WriteLine("maka tiga input data angka" + a + " " + b + " " + " " + c + "adalah" + hasil);
        }
    }
}
