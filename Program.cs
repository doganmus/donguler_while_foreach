using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak consol dan girilen sayıya kadar, sayı dahil ortalama hesaplayıp consola yazdıran program
            /*Console.Write("lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            

            // a dan z ye kadar tüm harflari consol a yazdıralaım
            char character ='a';
            while (character<'z')
            {
                Console.WriteLine(character);
                character++;
            }*/
            

            Console.WriteLine("*****Foreach******");
            string[] arabalar = {"bmw","ford","toyota","nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);               
            }
            
        }

            

            
        
    }
}
