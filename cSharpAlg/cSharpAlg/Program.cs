using System;

namespace cSharpAlg
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
              Kullanıcının girdiği 5 adet sayıyı bir diziye atayarak, bu dizide bulunan 
              çift sayıların ortalamasını ekrana yazan konsol uygulaması

            int[] sayilar = new int[5];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Bir Sayı Giriniz: ");
                int deger = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = deger;
                if (sayilar[i] % 2 == 0)
                {
                    int ort = sayilar[i] / 2;
                    Console.WriteLine("Ortalama: " + ort);
                }
            }
            Console.ReadKey();
            */




            /*
             Kullanıcıya kaç tane sayıyı toplayacağını sorup, kullanıcının toplayacağı 
             kadar sayıyı kullanıcıya tek tek soran ve kullanıcının yazdığı bu sayıların 
             toplamını ekrana yazan program 

            Console.Write("Kaç Tane Sayı Toplayacaksınız? ");
            int deger = Convert.ToInt32(Console.ReadLine());
            int gelensayi, toplam=0;
            for (int i = 0; i < deger; i++)
            {
                Console.WriteLine("Bir Sayı Giriniz = ");
                gelensayi = Convert.ToInt32(Console.ReadLine());
                toplam += gelensayi;
                Console.WriteLine("Toplam = " + toplam);
            }
            Console.ReadKey();
            */

            /*
             Klavyeden girilen 10 adet sayıdan en büyük ve en küçük olanı bulan program
            int buyuk = 0, kucuk = 0, sayi;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir Sayı Giriniz: ");
                int deger = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    buyuk = deger;
                    kucuk = deger;
                }
                if (kucuk > deger)
                { kucuk = deger; }
                if (buyuk < deger)
                { buyuk = deger; }
            }
            Console.WriteLine("En büyük sayı " + buyuk);
            Console.WriteLine("En küçük sayı " +  kucuk);
            Console.ReadKey();
            */


        }
    }
}
