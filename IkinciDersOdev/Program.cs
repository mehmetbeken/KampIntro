using System;

namespace IkinciDersOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Smart Phone";
            product1.productPrice = 5000;
            product1.productPiece = 25;
            product1.productSummary = "Yeni Çıkan ve Alanında En iyisi";

            Product product2 = new Product();
            product2.productName = "Smart TV";
            product2.productPrice = 8000;
            product2.productPiece = 45;
            product2.productSummary = "En kaliteli Ekran";

            Product product3 = new Product();
            product3.productName = "Smart Watch";
            product3.productPrice = 3000;
            product3.productPiece = 10;
            product3.productSummary = "Suya Dayanıklı";

            Product product4 = new Product();
            product4.productName = "AirPods";
            product4.productPrice = 1500;
            product4.productPiece = 20;
            product4.productSummary = "En Kaliteli Ses";

            Product[] products = new Product[] { product1, product2, product3, product4 };

            //ForEach İle Elemanları dolanma İslemi
            Console.WriteLine("For each ile");
            foreach (var product in products)
            {
                Console.WriteLine(product.productName + " : " + product.productSummary);

            }
            //For İle Elemanları Dolanma islemi
            Console.WriteLine("For ile");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName+":"+products[i].productSummary);
            }

            //While ile Elemanları dolanma islemi
            Console.WriteLine("While ile");
            int x = 0;
              while (x<products.Length)
            {
                Console.WriteLine(products[x].productName + ":" + products[x].productSummary);
                x++;
            }
        }
    }
    class Product
    {
        public string productName { get; set; }
        public string productSummary { get; set; }
        public int productPrice { get; set; }
        public int productPiece { get; set; }

    }
}
