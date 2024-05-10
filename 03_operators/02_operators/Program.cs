using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operators(Operatörler)
            // Toplama -> +
            // Çıkarma -> -
            // Çarpma -> *
            // Bölme -> /
            // Bir Arttırma -> ++
            // Bir Çıkarma -> --

            // Toplama ve Çıkarma

            //Toplama İşlemi:
            //Tam sayı ile ondalıklı sayı toplandığında, sonuç ondalıklı sayı hassasiyetindedir.
            //Ondalıklı sayı ile ondalıklı sayı toplandığında, sonuç ondalıklı sayı hassasiyetindedir.
            int number1 = 5;
            int number2 = 10;

            int resault = number1 + number2;
            Console.WriteLine(resault);  // 15

            int number3 = 5;
            double number4 = 20.10;

            double resault2 = number3 + number4;
            Console.WriteLine(resault2); // 25,1

            //Çıkarma İşlemi:
            //Tam sayı ile ondalıklı sayı çıkarıldığında, sonuç ondalıklı sayı hassasiyetindedir.
            //Ondalıklı sayı ile ondalıklı sayı çıkarıldığında, sonuç ondalıklı sayı hassasiyetindedir.
            int resault3 = number1 - number2;
            Console.WriteLine(resault3); // - 5

            double resault4 = number3 - number4;
            Console.WriteLine(resault4); // - 15,1


            // Çarpma ve Bölme

            // Çarpma İşlemi:
            //Tam sayı ile ondalıklı sayı çarpıldığında, sonuç ondalıklı sayı hassasiyetindedir.
            //Ondalıklı sayı ile ondalıklı sayı çarpıldığında, sonuç ondalıklı sayı hassasiyetindedir.

            int number5 = 6;
            double number6 = 2.3;

            double resault5 = number5 * number6;
            Console.WriteLine(resault5); // 13,8

            int number7 = 20;
            double number8 = 2.3;

            double resault6 = number7 * number8;
            Console.WriteLine(resault6);  // 46

            //Bölme İşlemi:
            //Tam sayı ile ondalıklı sayı bölündüğünde, sonuç ondalıklı sayı hassasiyetindedir.
            //Ondalıklı sayı ile ondalıklı sayı bölündüğünde, sonuç ondalıklı sayı hassasiyetindedir.
            int number9 = 30;
            int number10 = 9;

            int resault7 = number9 / number10;
            Console.WriteLine(resault7); // 3

            double number11 = 30.0;
            double number12 = 9.0;

            double resault8 = number11 / number12;
            Console.WriteLine(resault8); // 3,33333333333333

            // Mod Alma:
            int number13 = 10;
            int number14 = 3;

            int resault9 = number13 % number14;
            Console.WriteLine(resault9); // 1

            int number15 = 11;
            double number16 = 2.0;
            
            double resault10 = number15 % number16;
            Console.WriteLine(resault10); // 1


            // Arttırma(++) ve Azaltma(--)
            int number17 = 12;
            Console.WriteLine(number17); // 12

            number17++;
            Console.WriteLine(number17); // 11

            number17--;
            Console.WriteLine(number17); // 12

            double number18 = 3.14;
            Console.WriteLine(number18); // 3.14

            number18++;
            Console.WriteLine(number18); // 4.14

            number18--;
            Console.WriteLine(number18); // 3.14




            // Karşılaştırma Operatörleri:

            // Eşitlik Operatörü(==):
            // İki değeri karşılaştırmak için kullanılır.
            // İki değer birbirine eşitse, true döndürür; aksi halde false döndürür.
            
            double number19 = 5.8;
            int number20 = 5;
            bool resault11 = (number19 == number20); // false
            Console.WriteLine(resault11);


            // Eşitsizlik Operatörü(!=):
            // İki değeri karşılaştırmak için kullanılır.
            // İki değer birbirine eşit değilse, true döndürür; aksi halde false döndürür.
            double number21 = 5.80;
            double number22 = 5.8;
            bool resault12 = (number21 != number22); // false
            Console.WriteLine(resault12);

            // Büyüktür Operatörü(>):
            // Bir değerin diğerinden büyük olup olmadığını kontrol etmek için kullanılır.
            // İlk değer ikinciden büyükse, true döndürür; aksi halde false döndürür.
            int number23 = 10;
            int number24 = 5;
            bool resault13 = (number23 > number24); // true
            Console.WriteLine(resault13);

            // Küçüktür Operatörü(<):
            // Bir değerin diğerinden küçük olup olmadığını kontrol etmek için kullanılır.
            // İlk değer ikinciden küçükse, true döndürür; aksi halde false döndürür.
            int number25 = 6;
            double number26 = 6.38;
            bool resault14 = (number25 < number26); // true
            Console.WriteLine(resault14);

            //            Büyük Eşittir Operatörü(>=):
            // Bir değerin diğerinden büyük veya eşit olup olmadığını kontrol etmek için kullanılır.
            // İlk değer ikinciden büyük veya eşitse, true döndürür; aksi halde false döndürür.
            int number27 = 10;
            int number28 = 10;
            bool resault15 = (number27 >= number28); // true
            Console.WriteLine(resault15);

            // Küçük Eşittir Operatörü(<=):
            // Bir değerin diğerinden küçük veya eşit olup olmadığını kontrol etmek için kullanılır.
            // İlk değer ikinciden küçük veya eşitse, true döndürür; aksi halde false döndürür.
            double number29 = 10.0;
            int number30 = 10;
            bool resault16 = (number29 <= number30); // true
            Console.WriteLine(resault16);


            // Mantıksal Operatörler:
            // 1- &&(AND-ve):
            // İki mantıksal koşulun her ikisinin de doğru(true) olması durumunda sonuç doğru(true) olur.
            // Eğer herhangi bir koşul yanlış(false) ise, sonuç yanlış(false) olur.
            // Kullanımı: if, while, for gibi kontrol yapıları içinde veya koşullu ifadelerde kullanılır.

            int number31 = 10;
            int number32 = 10;
            int number33 = 50;

            bool resault17 = number31 == number32 && number31 < number33;
            Console.WriteLine(resault17); // true

            bool resault18 = number31 == number32 && number31 > number33;
            Console.WriteLine(resault18);  // false


            // 2- || (OR-veya):
            // İki mantıksal koşuldan en az birinin doğru(true) olması durumunda sonuç doğru(true) olur.
            // Her iki koşul yanlış(false) ise, sonuç yanlış(false) olur.
            // Kullanımı: if, while, for gibi kontrol yapıları içinde veya koşullu ifadelerde kullanılır.

            int number34 = 3;
            int number35 = 3;
            double number36 = 3.58;

            bool resault19 = number34 == number35 || number35 == number36;
            Console.WriteLine(resault19);  // true

            bool resault20 = number34 > number35 || number35 > number36;
            Console.WriteLine(resault20); // false


            // 3- !(NOT-değil):
            // Bir mantıksal koşulun tersini almak için kullanılır.
            // Bir koşulun doğru(true) olması durumunda sonuç yanlış(false) olarak, koşul yanlış(false) olması durumunda sonuç doğru(true) olarak döndürülür.
            // Kullanımı: Genellikle if, while, for gibi kontrol yapıları içinde veya koşullu ifadelerde kullanılır.

            bool value1 = true;
            bool resault21 = !value1;
            Console.WriteLine(resault21); // false

            int number37 = 13;
            int number38 = 13;
            bool resault22 = !(number38 == number37);
            Console.WriteLine(resault22); // false



            Console.ReadLine();

        }
    }
}









