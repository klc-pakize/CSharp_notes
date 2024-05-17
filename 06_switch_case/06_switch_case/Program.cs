using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _06_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch-case:
            // Belirli bir değişkenin değerine göre farklı kod bloklarını çalıştırmak için kullanılan bir kontrol yapısıdır.
            // switch-case yapısı, çok sayıda if-else if yapısını daha düzenli ve okunabilir bir şekilde yazmak için kullanılır.
            // Genel sözdizimi şu şekildedir:

            // switch (ifade)
            // {
            //    case değer1:
            //      // Kod bloğu 1
            //    break;
            //    case değer2:
            //      // Kod bloğu 2
            //    break;
            //    case değerN:
            //      // Kod bloğu N
            //    break;
            //    default:
            //      // Varsayılan kod bloğu
            //    break;
            // }
            // ifade: Kontrol edilecek değişken veya ifade.
            // değer1, değer2, ... değerN: ifade ile karşılaştırılacak olası değerler.
            //break: switch bloğundan çıkmayı sağlar. Her case bloğunun sonunda bulunmalıdır.
            // default: Hiçbir case değeri eşleşmediğinde çalışacak kod bloğu(isteğe bağlı).

            double balance = 40000.0;
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1- Bakiye Sorgulama");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("4- Çıkış Yap");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Güncel Bakiyeniz: " + balance);
                    break;

                case 2:
                    Console.WriteLine("Çekmek istediğiniz tutar: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    if (amount > balance)
                    {
                        Console.WriteLine("Güncel bakiyeniz çekmek istediğiniz tutardan azdır.");
                    }

                    else
                    {
                        Console.WriteLine("İşleminiz gerçekleştiriliyor. Lütfen ayrılmayınız.");
                        balance -= amount;
                        Console.WriteLine("Güncel bakiyeniz: " + balance);
                    }
                    break;

                case 3:
                    Console.WriteLine("Yatırmak istediğiniz tutar: ");
                    double amount2 = Convert.ToDouble(Console.ReadLine());

                    balance += amount2;

                    Console.WriteLine("Güncel Bakiyeniz: " + balance);
                    break;

                case 4:
                    Console.WriteLine("Çıkış işleminiz gerçekleştiriliyor, kartınızı unutmayınız.");
                    break;

                default:
                    Console.WriteLine("Geçerli bir işlem seçiniz.");
                    break;
            }


            Console.ReadLine();

        }
    }
}
