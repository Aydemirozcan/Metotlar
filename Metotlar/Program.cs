using System;
// don't repaet yourself-   DRY   -  CLEAN CODE    - BEST PRACTİCE
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


             string urunAdi = "Elma";
             double fiyati = 15;
             string aciklama = "Amasya elması";


             Urun urun1 = new Urun();
             urun1.Adi = "Elma";
             urun1.Fiyati = 15;
             urun1.Aciklama = "Amasya elması";


             Urun urun2 = new Urun();
             urun2.Adi = "Karpuz";
             urun2.Fiyati = 80;
             urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (Urun urun in urunler)

            {


                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------");


            }








            Console.WriteLine("------------Metotlar--------------");
           
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Armut", "Diyarbakır karpuzu", 12, 8);
            

        }
    }
}
