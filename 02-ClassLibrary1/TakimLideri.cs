using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassLibrary1
{
    public class TakimLideri : PersonelBilgileri
    {
        public int ekibindekiYazilimciSayisi { get; set; }

        public void TestEt()
        {
            Console.WriteLine($"{adiSoyadi} takımını test ediyor.");
        }

        public void Denetle()
        {
            Console.WriteLine($"{adiSoyadi} takımını denetliyor.");
        }

        public void IzinleriOnayla()
        {
            Console.WriteLine($"{adiSoyadi} izinleri onaylıyor.");
        }
    }
}
