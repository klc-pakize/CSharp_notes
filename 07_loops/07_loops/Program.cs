using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Döngüler, belirli bir kod bloğunu tekrarlı olarak çalıştırmak için kullanılır.
            // Döngüler, genellikle belirli bir koşul sağlandığı sürece çalışır ve bu koşul sağlanmadığında döngü sona erer.
            // C# dilinde kullanılan başlıca döngü türleri şunlardır: for, while, do-while, ve foreach.


            // 1- for Döngüsü
            // for döngüsü, genellikle belirli bir sayıda tekrar edilmesi gereken durumlar için kullanılır.
            // Döngünün başında bir sayaç değişkeni tanımlanır, koşul kontrol edilir ve her iterasyonda sayaç güncellenir.

            // Sözdizimi:
            // for (başlangıç; koşul; artırma / azaltma)
            // {
            // Tekrarlanacak kod bloğu
            // }

            for (int sayi = 0; sayi < 5; sayi++)
            {
                Console.WriteLine("Değer: " + sayi);
            }
            // Bu örnekte, i değişkeni 0'dan başlayarak 5'e ulaşana kadar döngü her seferinde i'nin değerini artırır ve bu değeri yazdırır.


            // 2- while Döngüsü
            // while döngüsü, belirli bir koşul doğru olduğu sürece çalışır.
            // Koşul her iterasyonun başında kontrol edilir.

            // Sözdizimi:
            // while (koşul)
            // {
            // Tekrarlanacak kod bloğu
            // }

            int sayi2 = 0;
            while (sayi2 < 5)
            {
                Console.WriteLine("Değer: " + sayi2);
                sayi2++;
            }
            // Bu örnekte, i değişkeni 0'dan başlayarak 5'e ulaşana kadar döngü çalışır ve her seferinde i'nin değerini yazdırır.


            // 3- do -while Döngüsü
            // do -while döngüsü, while döngüsünden farklı olarak koşulu döngünün sonunda kontrol eder.
            // Bu nedenle, kod bloğu en az bir kez çalışır.

            // Sözdizimi:
            // do
            // {
            // Tekrarlanacak kod bloğu
            // } while (koşul);

            int i = 0;
            do
            {
                Console.WriteLine("Değer: " + i);
                i++;
            } while (i < 5);
            // Bu örnekte, i değişkeni 0'dan başlayarak 5'e ulaşana kadar döngü çalışır ve her seferinde i'nin değerini yazdırır.
            // Kod bloğu en az bir kez çalışır.


            // 4- foreach Döngüsü
            // foreach döngüsü, bir koleksiyon veya dizi üzerinde iterasyon yapmak için kullanılır.
            // Bu döngü, koleksiyonun her bir elemanını sırasıyla işler.

            //Sözdizimi:
            // foreach (tip eleman in koleksiyon)
            // {
            // Tekrarlanacak kod bloğu
            // }

            string[] meyveler = { "Elma", "Armut", "Muz" };

            foreach (string meyve in meyveler)
            {
                Console.WriteLine("Meyve: " + meyve);
            }
            // Bu örnekte, meyveler dizisindeki her bir eleman meyve değişkenine atanır ve yazdırılır.


            // Döngülerde Kullanılan Kontrol İfadeleri
            // break: Döngüyü sonlandırmak için kullanılır. break ifadesi çalıştırıldığında, döngü tamamen sona erer ve döngüden sonraki koda geçilir.

            for (int sayi3 = 0; sayi3 < 10; sayi3++)
            {
                if (sayi3 == 5)
                {
                    break; // Döngü 5 olduğunda sona erer
                }
                Console.WriteLine("Değer: " + sayi3);
            }

            // continue: Döngünün o anki iterasyonunu sonlandırır ve bir sonraki iterasyona geçer.

            for (int sayi4 = 0; sayi4 < 10; sayi4++)
            {
                if (sayi4 % 2 == 0)
                {
                    continue; // Çift sayıları atlar
                }
                Console.WriteLine("Değer: " + sayi4);
            }



            for (int carpilan = 1; carpilan <= 10; carpilan++)
            {
                for (int carpan = 1; carpan <= 10; carpan++)
                {
                    Console.WriteLine(carpilan + " * " + carpan + " = " + (carpilan * carpan));
                }
            }



            int remainingAttempts = 3;
            string dbUsername = "developer";
            string dbPassword = "developer123";

            do
            {
                Console.WriteLine("Kullanıcı adınızı ve şifrenizi sıralı bir şekilde giriniz: ");
                string usernameInput = Console.ReadLine();
                string passwordInput = Console.ReadLine();

                if (dbUsername == usernameInput && dbPassword == passwordInput)
                {
                    Console.WriteLine("Kullanıcı adı ve şifreniz doğru. Anasayfaya yönlendiriliyorsunuz.");
                    break;
                }
                else
                {
                    remainingAttempts--;

                    if (remainingAttempts > 0)
                    {
                        Console.WriteLine($"Girmiş olduğunuz kullanıcı adı veya şifre yanlış. {remainingAttempts} deneme hakkınız kalmıştır. Lütfen tekrar giriniz.");
                    }
                    else
                    {
                        Console.WriteLine("Hakkınız bitmiştir. Daha sonra tekrar deneyiniz.");
                    }
                }
            } while (remainingAttempts > 0);



            Console.WriteLine("Lütfen pozitif bir tam sayı değeri giriniz: ");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int number=0; number < userInputNumber; number++)
            {
                sum += number;
            }

            if ((sum / userInputNumber) >= 50)
            {
                Console.WriteLine("Ortalaması 50'e eşit veya büyük.");
            }
            else
            {
                Console.WriteLine("Ortalaması 50'den küçük.");
            }



            Console.ReadLine();
        }
    }
}
