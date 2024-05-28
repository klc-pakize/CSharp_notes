using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _09_method
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Metotlar, belirli bir işlevi gerçekleştirmek için tanımlanan kod bloklarıdır.
            // Metotlar, kodun yeniden kullanılabilirliğini artırır, daha temiz ve okunabilir kod yazmayı sağlar.

            // Metot Tanımlama
            // Bir metot, geri dönüş tipi, adı, parametre listesi ve metot gövdesi olmak üzere dört ana bileşenden oluşur.

            // Sözdizimi
            // geriDönüşTipi MetotAdı(parametreListesi)
            // {
            //      Metot gövdesi
            // }

            // geriDönüşTipi: Metot çağrıldığında döndürülecek veri tipini belirtir. Eğer metot bir değer döndürmüyorsa, void anahtar kelimesi kullanılır.
            // MetotAdı: Metodun adını belirtir.
            // parametreListesi: Metot için gerekli olan parametreleri(argümanları) belirtir.Parametreler veri tipi ve isimle tanımlanır.
            // Metot Gövdesi: Metodun gerçekleştireceği işlemleri içeren kod bloğudur.



            //Metot Örnekleri
            // 1- Değer Döndürmeyen(void) Metot

            // static void Selamla()
            // {
            //     Console.WriteLine("Merhaba!");
            // }
            // Bu metot, ekrana "Merhaba!" yazdırır ve hiçbir değer döndürmez.

            // 2- Değer Döndüren Metot
            // static int Topla(int a, int b)
            //{
            //    return a + b;
            //}
            // Bu metot, iki tamsayıyı toplar ve sonucu döndürür.

            // Metot Çağırma
            // Metotları tanımladıktan sonra, onları çağırarak kullanabilirsiniz.

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        Selamla();

            //        Topla(3, 5);
            //        Console.WriteLine("Toplam: " + sonuc);
            //    }

            //    static void Selamla()
            //    {
            //        Console.WriteLine("Merhaba!");
            //    }

            //    static int Topla(int a, int b)
            //    {
            //        return a + b;
            //    }
            //}
            // Bu örnekte, Selamla ve Topla metotları Main metodu içinde çağrılır.

            // Parametre Geçirme
            // Metotlara parametre geçirebilirsiniz.Parametreler, metot tanımında belirtildiği gibi veri tipi ve isimle tanımlanır.

            //Değer Tipleri ve Referans Tipleri
            //Değer Tipleri: Metoda değer tipi olarak geçirilen değişkenlerin kopyası alınır.Metot içinde yapılan değişiklikler, orijinal değişkeni etkilemez.




            // Parametresiz değer döndürmeyen
            Hello();
            FullNamePrint();

            // Parametreli değer döndürmeyen
            Sum(4, 8);
            NameSurnamePrint("Ahmet", "Yılmaz");

            // Paremetreli değer döndüren
            int resaultSum = ReturnSum(5, 7);
            Console.WriteLine(resaultSum);
            string resaultFullname = RetunrFullName("Ahmet", "Yılmaz");
            Console.WriteLine(resaultFullname);



            Console.Write("Lütfen bir sayi giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int resaultSquare = Squaring(number);

            if (resaultSquare > 25)
            {
                Console.WriteLine("Sayının karesi 25'ten büyüktür.");
            }
            else
            {
                Console.WriteLine("Sayının karesi 25'e eşit veya küçüktür.");
            }



            Console.Write("Lütfen bir sayi giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            string resaultEvenOdd = EvenOdd(number2);
            Console.WriteLine(resaultEvenOdd);



            Console.Write("Lütfen 1.sayiyi giriniz: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2.sayiyi giriniz: ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Checking(number3, number4);


            Console.ReadLine();
        }
        static void Hello()
        {
            Console.WriteLine("Selamlar");
        }

        static void FullNamePrint()
        {
            Console.WriteLine("Ahmet Yılmaz");

        }

        static void Sum(int sayi1, int sayi2)
        {
            Console.WriteLine("Sayıların toplamı: " + (sayi1 + sayi2));
        }

        static void NameSurnamePrint(string isim, string soyisim)
        {
            Console.WriteLine("Merhaba, " + isim + " " + soyisim);
        }

        static int ReturnSum(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        static string RetunrFullName(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }

        static int Squaring(int sayi)
        {
            return sayi * sayi;
        }

        static string EvenOdd(int sayi)
        {
            if (sayi % 2 == 0)
            {
                return "Girilen sayi çiftir";
            }
            else
            {
                return "Girilen sayi tektir";
            }
        }

        static void Checking(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine("1.sayi 2.sayidan büyüktür");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine("2.sayi 1.sayidan büyüktür.");
            }
            else
            {
                Console.WriteLine("1.sayi ve 2.sayi birbirine eşittir.");
            }
        }
    }
}
