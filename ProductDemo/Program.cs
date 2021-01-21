using System;

namespace ProductDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding my products here:
            Products product1 = new Products();
            product1.ProductId = 1;
            product1.ProductName = "Apple iPhone 11 Pro";
            product1.ProductDescription = "iPhone 11 Pro smartphone was launched on 10th September 2019. " +
                "The phone comes with a 5.80-inch touchscreen display with a resolution of 1125x2436 pixels at a pixel density of 458 pixels per inch (ppi)." +
                " iPhone 11 Pro is powered by a hexa-core Apple A13 Bionic processor. It comes with 4GB of RAM.";
            product1.UnitPrice = 999;

            Products product2 = new Products();
            product2.ProductId = 2;
            product2.ProductName = "Xiaomi Mi 10 Pro";
            product2.ProductDescription = "The Xiaomi Mi 10 Pro is the Chinese manufacturer's brand-new high-end device, offering premium specs all around, " +
                "including Qualcomm's new top-end Snapdragon 865 chipset and a 6.67-inch display with FHD+ resolution";
            product2.UnitPrice = 1095;

            Products product3 = new Products();
            product3.ProductId =3;
            product3.ProductName = "Huawei Mate 40 Pro";
            product3.ProductDescription = "Huawei Mate 40 Pro is officially announced on October 22, 2020. The dimension of the device is 162.9 x 75.5 x 9.1 mm while it weighs 212 grams." +
                " The device is powered by the Kirin 9000 5G Octa-core processor";
            product3.UnitPrice = 1499;

            //I am creating an array of products in order to loop them easily:
            Products[] products = new Products[] { product1, product2, product3 };

            Console.WriteLine("*-*-*-*-* Example of For Loop *-*-*-*-* ");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductId);
                Console.WriteLine("Ürün adı: " + products[i].ProductName);
                Console.WriteLine("Ürün Açıklaması: " + products[i].ProductDescription);
                Console.WriteLine("Ürün Fiyatı: " + "$" + products[i].UnitPrice);
            }

            Console.WriteLine("*-*-*-*-* Example of Foreach Loop *-*-*-*-*");

            foreach (Products product in products)
            {
                Console.WriteLine(product.ProductId);
                Console.WriteLine("Ürün adı: " + product.ProductName);
                Console.WriteLine("Ürün Açıklaması: " + product.ProductDescription);
                Console.WriteLine("Ürün Fiyatı: " + "$" + product.UnitPrice);
            }

            Console.WriteLine("*-*-*-*-* Example of While Loop *-*-*-*-*");
            int whileLoop = 0;
            while (whileLoop<products.Length)
            {
                Console.WriteLine(products[whileLoop].ProductId);
                Console.WriteLine("Ürün adı: " + products[whileLoop].ProductName);
                Console.WriteLine("Ürün Açıklaması: " + products[whileLoop].ProductDescription);
                Console.WriteLine("Ürün Fiyatı: " + "$" +products[whileLoop].UnitPrice);
                whileLoop++;
            }

            Console.WriteLine("All products have listed with for, foreach and while loops.");
        }
    }
}
