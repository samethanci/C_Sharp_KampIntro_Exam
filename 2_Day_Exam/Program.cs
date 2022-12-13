using System;

namespace _2_Day_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Marka = "Bmw";
            product1.Model = "5 Serisi";
            product1.Fiyat = "3375000 TL";
            product1.Yil = 2020;
            product1.YakitTuru = "Dizel";
            product1.Vites = "Otomatik";
            product1.Km = 10258;
            product1.KasaTipi = "Coupe";
            product1.MotorHacmi = "1998 cc";
            product1.Renk = "Siyah";



            Product product2 = new Product() { Id = 2, Marka = "Mercedes-Benz", Model = "E Serisi", Fiyat = "3500000 TL", Yil = 2021,
                                                YakitTuru = "Hybrid", Vites = "Otomatik", Km = 8650, KasaTipi = "Sedan", 
                                                MotorHacmi = "1998cc", Renk = "Beyaz"
            };

            Product product3 = new Product() {
                Id = 3,
                Marka = "Laga",
                Model = "Vega",
                Fiyat = "50000 TL",
                Yil = 2000,
                YakitTuru = "Benzin",
                Vites = "Manuel",
                Km = 133500,
                KasaTipi = "Station Wagon",
                MotorHacmi = "1598cc",
                Renk = "Bordo"
            };

            Product[] arabalar = new Product[] { product1, product2, product3};


            //foreach kullanımı
            /*
            foreach (Product araba in arabalar)
            {
                Console.WriteLine($"Arabanın Markası: {araba.Marka} " +
                    $"Arabanın Modeli: {araba.Model} " +
                    $"Arabanın Fiyatı: {araba.Fiyat} " +
                    $"Arabanın Üretim Tarihi: {araba.Yil} " +
                    $"Arabanın Yakıt Türü: {araba.YakitTuru} " +
                    $"Arabanın Vites Türü: {araba.Vites} " +
                    $"Arabanın Kilometresi: {araba.Km} " +
                    $"Arabanın Kasa Türü: {araba.KasaTipi} " +
                    $"Arabanın Motor Hacmi: {araba.MotorHacmi} " +
                    $"Arabanın Rengi: {araba.Renk}");
                Console.WriteLine("******************************************");
            }
            */


            // for kullanımı
            /*
            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine("Arabanın Markası: " + arabalar[i].Marka);
                Console.WriteLine("Arabanın Modeli: " + arabalar[i].Model);
            }*/
            

            // while kullanımı
            /*
            int i = 0;
            while (i < arabalar.Length)
            {
                Console.WriteLine("Arabanın Markası: " + arabalar[i].Marka);
                Console.WriteLine("Arabanın Modeli: " + arabalar[i].Model);
                i++;
            }
            */
        }
    }
}
