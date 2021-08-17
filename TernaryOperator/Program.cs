using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ternary Operator
            string kullaniciAdi = "";
            string sifre = "";
            Console.WriteLine("Kullanici Adı Girin");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Sifre Giriniz");
            sifre = Console.ReadLine();
            string durum = (kullaniciAdi == "admin" && sifre == "12345") ? "Giriş Başarılı" : "Kullanıcı Adı veya Şifre Hatalı";
            Console.WriteLine(durum);



            //Switch&Case
            Console.WriteLine("Lütfen 1.Sayiyi Giriniz");
            int sayi1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Sayiyi Giriniz");
            int sayi2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İşlem Türünü Giriniz");
            Console.WriteLine("toplama=1,çıkarma=2,çarpma=3,bölme=4");
            int islem = Int32.Parse(Console.ReadLine());

            switch (islem)
            {
                case 1:Console.WriteLine(sayi1 + sayi2); break;
                case 2: Console.WriteLine(sayi1 - sayi2); break;
                case 3: Console.WriteLine(sayi1 * sayi2); break;
                case 4: Console.WriteLine(sayi1 / sayi2); break;

                default:Console.WriteLine("Hata Böyle bir işlem bulunamadı"); break;


            }

            int tahmin = 0, sayac = 0, tutulan;
            Random rastgele = new Random();
            tutulan = rastgele.Next(1, 100);
            while (tahmin!=tutulan)
            {
                sayac++;
                Console.WriteLine("Sayi Giriniz");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if(tahmin>tutulan)
                {
                    Console.WriteLine("Sayiyi Kücült");
                }
                else if (tahmin<tutulan)
                {
                    Console.WriteLine("Sayiyi Büyült");
                }
            }
            Console.WriteLine("Tebrikleer.");
            Console.WriteLine("{0} hakkınızda bildiniz ", sayac);
            
          
            


        }
    }
}
