using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassLibrary1
{
    public class ProjeYoneticisi : PersonelBilgileri
    {
        public void Denetle()
        {
            Console.WriteLine($"{adiSoyadi} projeyi denetliyor.");
        }

        public void IzinleriOnayla()
        {
            Console.WriteLine($"{adiSoyadi} izinleri onaylıyor.");
        }

        public void MusteriIleGorus()
        {
            Console.WriteLine($"{adiSoyadi} müşteri ile görüşüyor.");
        }
    }
}
