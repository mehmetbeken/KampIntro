﻿using System;

namespace MetotlarDers3
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+":"+urun.Fiyati);
            }
            Console.WriteLine("------------METOTLAR------------");
            //Instance
            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,15);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,20);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,44);



        }
    }
}
