using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _02_data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable (Değişken):
            // 1- Tanımlama: Bir değişkeni tanımlamak için; 
            //    veri türünü belirtip ardından değişkenin adını kullanarak bir atama operatörü(=) ile değeri atayabilirsiniz

            // 2- Veri Türleri: C# dilinde farklı veri türleri bulunur ve her biri belirli türde verileri saklamak için kullanılır.
            //    int, string, double, float, byte, short, long gibi temel veri türleri bulunur.
            //    Ayrıca, bool (boolean), char (karakter) gibi diğer veri türleri de mevcuttur.

            // 3- Değişken Adları: Değişken adları, belirli kurallara göre tanımlanmalıdır.
            //    Değişken adları, harf veya alt çizgi ile başlamalı ve daha sonra harf, rakam veya alt çizgi içerebilir.
            //    Ayrıca, anahtar kelimeler (if, else, while, gibi) değişken adları olarak kullanılamaz.

            // 4- Case Sensitivity: C# dilinde değişken adları büyük-küçük harfe duyarlıdır.
            //    Yani sayi ile Sayi farklı değişkenlerdir.


            // Data Type (Veri Türü):
            // 1- byte: 8 bitlik işaretli veya işaretsiz tamsayı değerlerini temsil eder.
            //    0 ile 255 arasındaki değerleri alır.

            byte firstByte = 7;
            Console.WriteLine(firstByte);

            byte secondByte = 46;
            Console.WriteLine(secondByte);

            // 343 değerini byte çeviremediği için HATA verir
            // byte thirdByte = 343;
            // Error CS0031  Constant value '343' cannot be converted to a 'byte'

            // byte.MaxValue, byte veri türünün en büyük temsil edilebilir değerini ifade eder.
            byte maxValueByte = byte.MaxValue;
            Console.WriteLine("Byte veri türünün alabileceği max değer sayısı " + maxValueByte);

            // byte.MinValue, byte veri türünün en küçük temsil edilebilir değerini ifade eder.
            byte minValueByte = byte.MinValue;
            Console.WriteLine("Byte veri türünün alabileceği min değer sayısı " + minValueByte);


            // 2- short: 16 bitlik işaretli tamsayı değerlerini temsil eder.
            //    -32,768 ile 32,767 arasındaki değerleri alabilir.

            short firstShort = -150;
            Console.WriteLine(firstShort);

            // 45000 değerini shor çeviremediği için HATA verir
            // short secondShort = 45000;
            // Error CS0031  Constant value '45000' cannot be converted to a 'short' 


            // short.MinValue, short veri türünün en büyük temsil edilebilir değerini ifade eder.
            short maxValueShort = short.MaxValue;
            Console.WriteLine("Short veri türünün alabileceği max değer sayısı " + maxValueShort);

            // short.MinValue, short veri türünün en küçük temsil edilebilir değerini ifade eder.
            short minValueShort = short.MinValue;
            Console.WriteLine("Short veri türünün alabileceği min değer sayısı " + minValueShort);


            // 3- int: 32 bitlik işaretli tamsayı değerlerini temsil eder. -2,147,483,648 ile 2,147,483,647 arasındaki değerleri alabilir.
            //    C# dilinde en sık kullanılan tamsayı veri türüdür.

            int firstInt = 45000;
            Console.WriteLine(firstInt);

            // 8500000000 değerini int çeviremediği için HATA verir.
            // int secondInt = 8500000000;
            // Error CS0266  Cannot implicitly convert type 'long' to 'int'.

            // 343.54 onalıkliı değerini int çeviremediği için HATA verir.
            // int thirdInt = 343.54;
            // Error CS0266  Cannot implicitly convert type 'double' to 'int'.


            // int.MinValue, int veri türünün en büyük temsil edilebilir değerini ifade eder.
            int maxValueInt = int.MaxValue;
            Console.WriteLine("int veri türünün alabileceği max değer sayısı " + maxValueInt);

            // int.MinValue, int veri türünün en küçük temsil edilebilir değerini ifade eder.
            int minValueInt = int.MinValue; 
            Console.WriteLine("int veri türünün alabileceği min değer sayısı " + minValueInt);


            // 4- long: 64 bitlik işaretli tamsayı değerlerini temsil eder.
            //    -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasındaki değerleri alabilir.

            long firstLong = 8500000000;
            Console.WriteLine(firstLong);

            //  8500000000.89 ondalıklı değeri long çeviremediği için HATA verir.
            // long secondLong = 8500000000.89;
            // Error CS0266  Cannot implicitly convert type 'double' to 'long'.


            // long.MinValue, long veri türünün en büyük temsil edilebilir değerini ifade eder.
            long maxValueLong = long.MaxValue;
            Console.WriteLine("long veri türünün alabileceği max değer sayısı " + maxValueLong);

            // long.MinValue, long veri türünün en küçük temsil edilebilir değerini ifade eder.
            long minValueLong = long.MinValue;
            Console.WriteLine("long veri türünün alabileceği min değer sayısı " + minValueLong);


            // 5- float: Ondalıklı sayıları temsil eder. 32 bitlik kayan nokta sayısıdır.
            //    Yaklaşık 7 haneli kesinliğe sahip olan ondalıklı sayılar için kullanılır.

            float firstFloat = 35.56f;
            Console.WriteLine(firstFloat);

            // Varsayılan olarak ondalık sayılar double veri türüne atanır ve daha sonra küçük bir tür olan float türüne atama yapılamaz.
            // C#'da bir ondalık sayıyı (double olarak anlamak önemlidir) float veri türüne açık bir şekilde dönüştürmeden atama yapmak bir hata oluşturur.
            // float secondFloat = 3.14;
            // Error CS0664  Literal of type double cannot be implicitly converted to type 'float'; use an 'F' suffix to create a literal of this type
            // Bu hatayı düzeltmek için; 
            float secondFloat = (float)3.14;
            float thirdFloat = -3.14f;

            // float.MinValue, float veri türünün en büyük temsil edilebilir değerini ifade eder.
            float maxValueFloat = float.MaxValue;
            Console.WriteLine("float veri türünün alabileceği max değer sayısı " + maxValueFloat);

            // float.MinValue, float veri türünün en küçük temsil edilebilir değerini ifade eder.
            float minValueFloat = float.MinValue;
            Console.WriteLine("float veri türünün alabileceği min değer sayısı " + minValueFloat);


            // 6- double: Ondalıklı sayıları temsil eder. 64 bitlik çift hassasiyetli kayan nokta sayısıdır.
            //    Daha büyük bir aralık ve daha yüksek bir kesinlik sunar.
            //    C# dilinde varsayılan ondalık sayı türüdür.

            double firstDouble = 3855.56;
            Console.WriteLine(firstDouble);

            double secondDouble = -6935.56;
            Console.WriteLine(secondDouble);

            // double.MinValue, double veri türünün en büyük temsil edilebilir değerini ifade eder.
            double maxValueDouble = double.MaxValue;
            Console.WriteLine("double veri türünün alabileceği max değer sayısı " + maxValueDouble);

            // double.MinValue, double veri türünün en küçük temsil edilebilir değerini ifade eder.
            double minValueDouble = double.MinValue;
            Console.WriteLine("double veri türünün alabileceği min değer sayısı " + minValueDouble);


            // 7- char: Tek bir karakteri temsil eden bir veri türüdür.
            //    Örneğin, harfler(a, b, c), rakamlar(0, 1, 2), özel semboller(@, #, &) ve kaçış dizileri (\n, \t) char veri türüyle temsil edilebilir.
            //    char veri türü, tek tırnak (') işareti içinde belirtilir. Örneğin: 'A', '9', ' % '.

            char firstChar = 'A';
            Console.WriteLine(firstChar);

            char secondChar = '#';
            Console.WriteLine(secondChar);

            char thirdChar = '\n';
            Console.WriteLine(thirdChar);

            // Error CS0029	Cannot implicitly convert type 'string' to 'char'
            // char errChar = "0";

            // Error CS1012	Too many characters in character literal
            //char errChar = 'AB';


            // 8- string: metin veya dizi verilerini temsil eden bir veri türüdür.
            //    C#'da metin dizileri çift tırnak (") işareti içinde belirtilir.
            //    string veri türü, birden fazla karakterden oluşan metinleri saklamak için kullanılır.
            //    Metin, harfler, rakamlar, boşluklar ve özel semboller içerebilir.

            string firstString = "Ahmet";
            Console.WriteLine(firstString);

            string secondString = "Hello World!";
            Console.WriteLine(secondString);

            string thirdString = "A";
            Console.WriteLine(thirdString);

            // Error CS1012	Too many characters in character literal
            //string errString = 'Helllo World!';


            // 9- bool: sadece iki değeri olan mantıksal bir veri türüdür: true(doğru) ve false(yanlış).
            //    Genellikle koşullu ifadelerde, döngülerde ve kontrol yapılarında kullanılır.
            //    bool veri türü, mantıksal ifadeleri değerlendirmek ve sonuçları belirlemek için kullanılır.
            //    Bir değişkenin veya ifadenin doğru(true) veya yanlış(false) olduğunu ifade etmek için kullanılır.

            bool firstBool = true;
            Console.WriteLine(firstBool);

            bool secondBool = false;
            Console.WriteLine(secondBool);

            bool thirdBool = 10 > 5;
            Console.WriteLine(thirdBool);

            // Error CS0029	Cannot implicitly convert type 'int' to 'bool'
            //bool fourthBool = 5;



            // 10- object: C# dilindeki en temel türlerden biridir ve herhangi bir türün referansını saklayabilen genel bir türdür.
            //     Tüm diğer türler, object türünden türetilir.
            //     Yani, object türü, C# dilinde tüm diğer türlerin atasıdır.
            //     Bu nedenle, bir object değişkeni herhangi bir türden bir değeri alabilir.
            //     Bir object değişkeni oluşturulduğunda, bellekte bir referansın yerini tutar.
            //     Bu referans, saklanan değerin türüne göre uygun türde bir nesneye işaret eder.
            //     object türü, çok çeşitli senaryolarda kullanılır, özellikle tip belirsizliği veya türler arası dönüşümler gerektiğinde kullanışlıdır.
            //     Ancak, object türünün kullanımı tür güvenliğini kaybettirebilir ve performansı etkileyebilir.
            //     Bu nedenle, mümkün olduğunca belirli türleri kullanmak ve gereksiz yere object türünden kaçınmak önemlidir.

            object firstObject = 10; // int türünden bir değer
            Console.WriteLine(firstObject);

            object secondObject = "Merhaba"; // string türünden bir değer
            Console.WriteLine(secondObject);

            object thirdObject = false; // bool türünde bir değer
            Console.WriteLine(thirdObject);
            
            object fourthObject = 12.5;  // double türünde bir değer
            Console.WriteLine(fourthObject);

            object fifthnObject = 5.89f; // float türünde bir değer
            Console.WriteLine(fifthnObject);

            Console.ReadLine();

        }
    }
}
