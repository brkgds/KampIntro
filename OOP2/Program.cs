﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi= "Demiroğ";
            musteri1.TcNo = "1233445677";

            // Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "435235";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);


        }
    }
}
