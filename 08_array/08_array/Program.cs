using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays (Diziler)
            // C# dilinde diziler (arrays) oldukça önemli ve yaygın olarak kullanılan veri yapılarıdır.
            // Diziler, aynı türdeki verilerin bir koleksiyonunu depolamak için kullanılır. 

            // Dizilerin Tanımlanması ve Başlatılması
            // C#'da dizi tanımlamak için köşeli parantezler [] kullanılır.
            // Diziler sabit bir boyuta sahiptir, yani tanımlandıktan sonra boyutları değiştirilemez.

            // Tek Boyutlu Dizi
            // Tanımlama
            int[] numbers;

            // Başlatma ve değer atama
            numbers = new int[5]; // 5 elemanlı bir dizi oluşturur

            // Tanımlama ve başlatma bir arada
            int[] numbers2 = new int[5];

            // Tanımlama, başlatma ve değer atama bir arada
            double[] double1 = new double[] { 1.15, 2.2, 3.14, 4.8, 5.65 };

            // Daha kısa bir yol
            string[] string1 = { "1", "2", "3", "4", "5" };


            // Çok Boyutlu Diziler
            // Çok boyutlu diziler(matrisler) de tanımlanabilir.
            // En yaygın olanı iki boyutlu dizilerdir.
            // Tanımlama
            int[,] matrix;

            // Başlatma ve değer atama
            matrix = new int[3, 3]; // 3x3 boyutlu bir matris oluşturur

            // Tanımlama ve başlatma bir arada
            int[,] matrix2 = new int[3, 3];

            // Tanımlama, başlatma ve değer atama bir arada
            int[,] matrix3 = new int[,] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Düzensiz(Jagged) Diziler
            // Düzensiz diziler, dizilerin dizisi olarak adlandırılır ve her alt dizi farklı uzunlukta olabilir.
            // Tanımlama
            int[][] jaggedArray;

            // Başlatma ve değer atama
            jaggedArray = new int[3][]; // 3 alt dizi içerir

            // Alt dizileri başlatma
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[1];

            // Değer atama
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };


            // Dizilere Erişim ve İşlemler
            // Dizi elemanlarına erişmek ve onları değiştirmek için dizin(indeks) kullanılır.Dizinler sıfırdan başlar.

            int[] numbers5 = { 1, 2, 3, 4, 5 };

            // Bir elemana erişim
            int firstElement = numbers[0]; // 1. elemana erişim

            // Bir elemanı değiştirme
            numbers5[1] = 20; // 2. elemanı 20 yapar

            // Dizi boyutu
            int length = numbers5.Length; // 5 döner

            // Döngü ile dizi elemanlarına erişim
            for (int i = 0; i < numbers5.Length; i++)
            {
                Console.WriteLine(numbers5[i]);
            }

            // foreach döngüsü ile dizi elemanlarına erişim
            foreach (int num in numbers5)
            {
                Console.WriteLine(num);
            }

            // Özel Diziler ve Yöntemler
            // C#'da dizilerle ilgili bazı özel yöntemler ve özellikler bulunmaktadır.

            // Array Sınıfı ve Yöntemleri
            // C# dilinde System.Array sınıfı, diziler üzerinde bazı yararlı yöntemler sağlar.

            int[] numbers6 = { 1, 2, 3, 4, 5 };

            // Diziyi tersine çevirme
            Array.Reverse(numbers6);

            // Diziyi sıralama
            Array.Sort(numbers6);

            // Eleman arama
            int index = Array.IndexOf(numbers6, 3); // 3'ün indeksi

            // Alt dizi oluşturma
            // int[] subArray = numbers6[1..3]; // 1 ve 2. indeksleri alır 8.0 verion ile çalışır

            // Alt dizi oluşturma
            int startIndex = 1;
            int length1 = 2;
            int[] subArray = new int[length];
            Array.Copy(numbers6, startIndex, subArray, 0, length1);

            // Alt diziyi yazdırma
            foreach (int number in subArray)
            {
                Console.WriteLine(number);
            }

            // Alternatif olarak, tüm dizi elemanlarını yazdırmak için:
            Console.WriteLine(string.Join(", ", subArray));


            // Çok Boyutlu Diziler Üzerinde İşlemler
            // Çok boyutlu diziler üzerinde de erişim ve işlemler yapılabilir.

            int[,] matrix4 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Bir elemana erişim
            int element = matrix4[1, 1]; // 5 döner

            // Bir elemanı değiştirme
            matrix4[2, 2] = 10;

            // Döngü ile erişim
            for (int i = 0; i < matrix4.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4.GetLength(1); j++)
                {
                    Console.Write(matrix4[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged Diziler Üzerinde İşlemler
            // Jagged dizilerle de benzer şekilde erişim ve işlemler yapılabilir.

            int[][] jaggedArray2 = {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6 }
            };

            // Bir elemana erişim
            int element1 = jaggedArray2[1][2]; // 5 döner

            // Bir elemanı değiştirme
            jaggedArray2[2][0] = 7;

            // Döngü ile erişim
            foreach (int[] arr in jaggedArray2)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }



            Console.Write("Kaç elemanlı bir array tanımlamak istiyorsunuz: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] userArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Array eklemek istediğiniz sayıyı giriniz: ");
                int arrayNumber = Convert.ToInt32(Console.ReadLine());
                userArray[i] = arrayNumber;
            }

            foreach (int arrayNumber in userArray)
            {
                Console.WriteLine(arrayNumber);
            }



            int[] defaultNumbers = { 10, 10, 20, 30, 25, 30, 50, 85, 100, 60, 5, 95, 5, 15, 60, 565, 55, 5 };
            int count = 0;

            Console.Write("Varsayılan dizenin içinde aratmak istediğiniz sayıyı giriniz: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < defaultNumbers.Length; i++)
            {
                if (defaultNumbers[i] == userNumber)
                {
                    count++;
                }
            }


            if (count == 0)
            {
                Console.WriteLine("Aratmak istediğiniz " + userNumber + " değeri varsayıla dizenin içinde yoktur.");
            }

            else
            {
                Console.WriteLine("Aratmak istediğiniz " + userNumber + " değeri Varsayılan dizenin içinde " + count + " adet bulunmaktadır.");
            }


            int[] numbersArray = new int[10];
            Console.WriteLine("Dizenin içerisine eleman olarak 10 adet sayı gönderiniz: ");

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int userIntValue = Convert.ToInt32(Console.ReadLine());
                numbersArray[i] = userIntValue;
            }

            int evenNumberCount = 0;
            int oddNumberCount = 0;
            int evenNumberSum = 0;
            int oddNumberSum = 0;

            foreach (int i in numbersArray)
            {
                if (i % 2 == 0)
                {
                    evenNumberCount++;
                    evenNumberSum += i;
                }
                else
                {
                    oddNumberCount++;
                    oddNumberSum += i;
                }
            }

            Console.WriteLine("Çift sayı adedi: " + evenNumberCount);
            Console.WriteLine("Çift sayıların toplamı: " + evenNumberSum);

            Console.WriteLine("Tek sayı adedi: " + oddNumberCount);
            Console.WriteLine("Tek sayıların tolamı: " + oddNumberSum);


            Console.ReadLine();
        }
    }
}
