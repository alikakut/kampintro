using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 5;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "ali";
            musteri1.Soyadi = "kakut";
            musteri1.TcNo = "555555555";

            //kodlama.io
            TüzelMusteri musteri2=new TüzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "456789";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo="4546498";


            Musteri musteri3= new GercekMusteri();    
            Musteri musteri4= new TüzelMusteri();


            MUsteriManager mUsteriManager=new MUsteriManager();
            mUsteriManager.ekle(musteri1);
            mUsteriManager.ekle(musteri2);  
        
        
        }
    }
}
