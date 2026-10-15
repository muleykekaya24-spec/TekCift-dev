using System;

namespace TekCiftOOP
{
    
    public class SayiKontrol
    {
       
        private int _sayi;

        
        public SayiKontrol()
        {
            _sayi = 0;
        }

        
        public int GetSayi()
        {
            return _sayi;
        }

       
        public void SetSayi(int sayi)
        {
            _sayi = sayi;
        }

        
        public string TekMiCiftMi()
        {
            if (_sayi % 2 == 0)
            {
                return "Çift";
            }
            else
            {
                return "Tek";
            }
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SayiKontrol sayiNesnesi = new SayiKontrol();
            string secim = "";

           
            while (secim != "N" && secim != "n")
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                string girdi = Console.ReadLine();

                int girilenSayi;
                bool basariliMi = int.TryParse(girdi, out girilenSayi);

                if (basariliMi)
                {
                    
                    sayiNesnesi.SetSayi(girilenSayi);

                    
                    Console.WriteLine($"Girilen sayı ({sayiNesnesi.GetSayi()}) bir {sayiNesnesi.TekMiCiftMi()} sayıdır.\n");
                }
                else
                {
                    Console.WriteLine("Hata: Lütfen geçerli bir tam sayı giriniz!!\n");
                }

                Console.Write("Devam etmek istiyor musunuz? (Çıkmak için N veya n giriniz): ");
                secim = Console.ReadLine();
                Console.WriteLine("--------------------------------------------");
            }

            Console.WriteLine("Programdan çıktınız. İyi günler..");
        }
    }
}