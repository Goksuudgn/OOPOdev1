using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassLibrary1
{
    public class PersonelBilgileri
    {
        public int kimlikNo { get; set; }
        public string adiSoyadi { get; set; }
        public decimal maas { get; set; }
        public string meslek { get; set; }


        public void IseGit()
        {
            Console.WriteLine($"{adiSoyadi} işe gidiyor.");
        }

        public void MolaYap()
        {
            Console.WriteLine($"{adiSoyadi} mola yapıyor.");
        }
    }
}
