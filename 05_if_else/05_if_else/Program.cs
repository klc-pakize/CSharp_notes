using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _05_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- if Yapısı
            // Belirli bir koşulun doğru(true) olduğu durumlarda bir kod bloğunu çalıştırmak için kullanılır.
            // Genel sözdizimi şu şekildedir:

            // if (condition(koşul))
            // {
            // Koşul doğru olduğunda çalışacak kod bloğu
            // }
            //condition: Bir mantıksal ifade veya bir değerdir. Eğer bu koşul doğruysa, ilgili kod bloğu çalıştırılır.

            int number = 10;
            if (number > 5)
            {
               Console.WriteLine("Sayı 5'ten büyüktür.");
             }


            // 2- else if Yapısı
            // Bir if koşulu yanlış olduğunda başka bir koşulu kontrol etmek için kullanılır.
            // Genel sözdizimi şu şekildedir:

            // if (condition1)
            // {
            // Koşul1 doğru olduğunda çalışacak kod bloğu
            // }
            // else if (condition2)
            // {
            // Koşul1 yanlış, koşul2 doğru olduğunda çalışacak kod bloğu
            // }
            // condition1: Birinci koşul.
            // condition2: İkinci koşul. Birinci koşul yanlış olduğunda kontrol edilir.

            int number2 = 10;
            if (number2 > 10)
            {
                Console.WriteLine("Sayı 10'dan büyüktür.");
            }
            else if (number2 <= 10)
            {
                Console.WriteLine("Sayı 10'dan küçük veya eşittir.");
            }
  
                        
            // 3- else Yapısı
            // Önceki tüm koşullar yanlış olduğunda çalışacak kod bloğunu belirtmek için kullanılır.
            // Genel sözdizimi şu şekildedir:

            // if (koşul)
            // {
                 // Koşul doğru olduğunda çalışacak kod bloğu
            // }
            // else
            // {
                 // Koşul yanlış olduğunda çalışacak kod bloğu
            // }
            
            int number3 = 2;
            if (number3 > 5)
            {
                 Console.WriteLine("Sayı 5'ten büyüktür.");
            }
            else
            {
                 Console.WriteLine("Sayı 5'ten küçük veya eşittir.");
            }


            
            
            
            Console.WriteLine("3 adet ders notu giriniz: ");
            int note1 = Convert.ToInt32(Console.ReadLine());
            int note2 = Convert.ToInt32(Console.ReadLine());
            int note3 = Convert.ToInt32(Console.ReadLine());
            double avg = (note1 + note2 + note3) / 3;

            if (avg >= 80 && avg <= 100)
            {
                Console.WriteLine("A+");
            }
            else if (avg >= 60 && avg < 80)
            {
                Console.WriteLine("A");
            }
            else if (avg >= 40 && avg < 60)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("F");
            }




            Console.WriteLine("Lütfen kilo bilginizi giriniz: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen boy bilginizi giriniz: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double body_mass_index = weight / (height * height);

            if (body_mass_index <= 18)
            {
                Console.WriteLine("Zayıf");
            }
            else if (body_mass_index > 18 && body_mass_index <= 25)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Obez");
            }

            
            
            
            
            double balance = 40000.0;
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1- Bakiye Sorgulama");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("4- Çıkış Yap");
            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine("Güncel Bakiyeniz: " + balance);
            }
            else if (operation == 2) 
            {
                Console.WriteLine("Çekmek istediğiniz tutar: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount > balance) 
                {
                    Console.WriteLine("Güncel bakiyeniz çekmek istediğiniz tutardan fazladır");
                }
                else
                {
                    Console.WriteLine("İşleminiz gerçekleştiriliyor. Lütfen ayrılmayınız.");
                    balance -= amount;
                    Console.WriteLine("Güncel bakiyeniz: " + balance);
                }
            }
            else if (operation == 3)
            {
                Console.WriteLine("Yatırmak istediğiniz tutar: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                balance += amount;
                Console.WriteLine("Güncel bakiyeniz: " + balance);
            }
            else if (operation == 4) 
            {
                Console.WriteLine("Çıkış işleminiz gerçekleştiriliyor, kartınızı unutmayınız.");
            }
            else
            {
                Console.WriteLine("Geçerli bir işlem seçiniz.");
            }




        Console.ReadLine();

        }
    }
}
