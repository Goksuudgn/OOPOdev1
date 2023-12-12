using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassLibrary1
{
    public class Yazilimci : PersonelBilgileri
    {
        public bool backEndMi { get; set; }
        public bool frontEndMi { get; set; }
        public string seviyesi { get; set; }

        public void KodYaz()
        {
            Console.WriteLine($"{adiSoyadi} kod yazıyor.");
        }

        public void TestEt()
        {
            Console.WriteLine($"{adiSoyadi} test ediyor.");
        }
    }
}
