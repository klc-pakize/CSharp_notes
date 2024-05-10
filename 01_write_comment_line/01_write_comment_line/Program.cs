using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_write_comment_line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comment Line (Yorum Satırı):
            // C# programlama dilinde, kodunuzun anlaşılmasını ve belki de başkalarıyla paylaşılmasını kolaylaştırmak için yorum satırları kullanabilirsiniz.
            // Yorum satırları, kodunuzun içindeki açıklamaları belirtmek için kullanılır.
            // Bu açıklamalar, kodun ne yaptığını, niçin yapıldığını veya nasıl çalıştığını açıklayabilir.

            // Tek satırlık yorumlar iki eğik çizgi (//) ile başlar ve o satırın sonuna kadar devam eder.

            // Çoklu satırlık yorumlar ise başlangıçta bir eğik çizgi ve bir yıldız (/*) ile başlar,
            // ve sonunda bir yıldız ve bir eğik çizgi (*/) ile sonlanır. Aradaki her şey yorum olarak kabul edilir.
            // Bu çoklu satırlık yorumlar, birden fazla satırı kapsayacak açıklamalar için kullanılır.
            // Örneğin:

            /* Bu çoklu satırlık yorum, 
               kodun bu kısmının ne yaptığını 
               daha detaylı açıklamak için kullanılabilir. */

            // Console'da herhangi bir çıktı almak isteniyorsa Console.WriteLine fonksiyonu kullanılabilir.
            Console.WriteLine("Hollo World.");

            // Console class'ının Write fonksiyonu, WriteLine fonksiyonu gibi konsol ekranında çıktı görüntülememizi sağlar.
            // WriteLine fonksiyonundan farklı olarak, Write fonksiyonu çıktıları yan yana görüntülerken, WriteLine fonksiyonu alt alta görüntüler.
            Console.Write("Hello");
            Console.Write("World");


            // Başlangıçta, kodumuzu çalıştırdığımızda, çalıştırılacak kodlar tamamlandığında konsol penceresi otomatik olarak kapanır.
            // Ancak, direkt olarak kapanmasını istemiyorsak Console.ReadLine() fonksiyonunu kullanabiliriz.
            // Console.ReadLine() fonksiyonu, asıl işlevi kullanıcıdan bir girdi almak olmasına rağmen, 
            // bir girdi girilene ve Enter tuşuna basılana kadar konsolun açık kalmasını sağlar.
            // Böylece, kullanıcı bir girdi yapmadığı sürece konsol penceresi kapanmaz.

            Console.WriteLine("\nPlease Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("User Name: " + name);
        
            Console.ReadLine();

        }

    }
}
