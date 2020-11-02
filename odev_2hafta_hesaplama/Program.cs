using System;

namespace odev_2hafta_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı Gir ");
            int ilk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Gir ");
            int iki = Convert.ToInt32(Console.ReadLine());
            /*
             * Console.WriteLine("Toplama işlemi için 1'e basınız n/ "
                   +"Çıkarma işlemi için 2'ye basınız n/"
                   +"Çarpma işlemi için 3' e basınız n/"
                   +"Bölme işlemi için 4'e basınız.");
             */
            Console.WriteLine("Toplama işlemi için +'a basınız.");
            Console.WriteLine("Çıkarma işlemi için -'ye basınız.");
            Console.WriteLine("Çarpma işlemi için *' e basınız.");
            Console.WriteLine("Bölme işlemi için /'e basınız.");

            string islem = Console.ReadLine();
            double toplam = 0;
            string secim="0";
            if (islem == "+")
            {
                toplam = ilk + iki;
                secim ="+";
            }
            else if (islem == "-")
            {
                toplam = ilk - iki;
                secim = "-";
            }
            else if (islem == "*")
            {
                toplam = ilk * iki;
                secim = "*";
            }
            else if(islem=="/"){
                toplam = ilk / iki;
                secim = "/";
            }
            else
            {
                Console.WriteLine("Lütfen doğru bir seçim yapınız.");
               
            }
            Console.WriteLine(ilk+secim+iki+"işleminin sonucu= "+toplam );
            Console.ReadKey();

        }
    }
}
