using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_girilen_2_sayıyı_toplayan_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1,sayi2,Toplam; //bunu öğrenmen iyi olmuş :)))
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen  Bir Sayı Daha Giriniz");
            sayi2 = Convert.ToInt32((Console.ReadLine()));
            Toplam = sayi1 + sayi2;
            //{ //bu paranteze gerek yok
            Console.WriteLine("Girdiğiniz Sayıların Toplamı = {0}",Toplam);
            //} //bu paranteze gerek yok
            Console.ReadKey();

        }
    }
}
