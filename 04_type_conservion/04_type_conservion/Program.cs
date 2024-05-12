using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_type_conservion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type Convertion(Tip Dönüşümü):

            // GetType() yöntemi, bir nesnenin tür bilgisini almak için kullanılan bir yöntemdir.
            // Bu yöntem, System.Object sınıfının bir üyesidir ve bu nedenle tüm nesneler tarafından kullanılabilir.


            // 1-Implicit Conversion(Otomatik Dönüşüm)
            // C# dilinde, bazı veri türleri otomatik olarak diğer veri türlerine dönüştürülebilir.
            // Bu dönüşümler genellikle daha geniş bir veri aralığından daha dar bir veri aralığına gerçekleşir ve veri kaybı riski olmaz.

            // byte -> short, int, long, float, double
            // short -> int, long, float, double
            // int -> long, float, double
            // long -> float, double
            // float -> double


            byte byteValue =  10;
            int intValue = byteValue; // byte -> int
            float floatValue = intValue; // int -> float
            double doubleValue = floatValue; // float -> double


            // 2-Explicit Conversion(Açık Dönüşüm)
            // Bazı durumlarda, C# dilinde veri türleri arasında açık bir dönüşüm belirtmek gerekir.
            // Bu dönüşümler, genellikle daha dar bir veri aralığından daha geniş bir veri aralığına gerçekleşir ve veri kaybı olabilir.
            // Ayrıca, bu tür dönüşümler, "cast" operatörü ((type)) kullanılarak gerçekleştirilir.

            // int -> byte, short, sting
            // long -> byte, short, int, sting
            // float -> byte, short, int, long, sting
            // double -> byte, short, int, long, float, sting



            int intDegisken = 10;
            byte byteDegisken = (byte)intDegisken; // int -> byte
            float floatDegisken = 3.14f;
            int intSonuc = (int)floatDegisken; // float -> int
            



            // 3-Explicit Conversion with Convert Class
            // C# dilinde, veri türleri arasında dönüşüm yapmak için Convert sınıfı da kullanılabilir.
            // Bu yöntemler, belirli durumlarda daha esnek olabilir.


            int valueInt = 10;
            byte valueByte = Convert.ToByte(valueInt); // int -> byte
            float valueDegisken = 3.14f;
            int resaultInt = Convert.ToInt32(valueDegisken); // float -> int
            string resaultStr = Convert.ToString(resaultInt);
            
            int intNumber = 10;
            string strNumber = intNumber.ToString(); // int'ten string'e dönüşüm
            Console.WriteLine(strNumber.GetType());


            // Console.ReadLine() fonksiyonu her zaman bir kullanıcı girdisini string olarak döndürür.
            // Bu fonksiyon, kullanıcıdan bir satır girişi almak için kullanılır ve aldığı girdiyi bir string olarak geri verir.

            Console.WriteLine("2 adet sayi giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number.GetType());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + number2);

            Console.ReadLine();
        }
    }
}
