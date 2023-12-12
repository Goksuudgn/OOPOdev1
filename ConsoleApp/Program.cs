using _02_ClassLibrary1;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazilimci yazilimci = new Yazilimci
            {
                kimlikNo = 2,
                adiSoyadi = "Kaan Akkaya",
                maas = 50000,
                meslek = "Yazılımcı",
                backEndMi = true,
                frontEndMi = false,
                seviyesi = "Mid"
            };

            yazilimci.IseGit();
            yazilimci.KodYaz();

            TakimLideri takimLideri = new TakimLideri
            {
                kimlikNo = 2,
                adiSoyadi = "Göksu Doğan",
                maas = 68000,
                meslek = "Takım Lideri",
                ekibindekiYazilimciSayisi = 5
            };

            takimLideri.IseGit();
            takimLideri.TestEt();
            takimLideri.Denetle();

            ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi
            {
                kimlikNo =3,
                adiSoyadi = "Gülay Toprak",
                maas = 50000,
                meslek = "Proje Yöneticisi"
            };

            projeYoneticisi.IseGit();
            projeYoneticisi.MusteriIleGorus();
            projeYoneticisi.Denetle();
        }
    }
}
