using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Document document = new Document("Контракт");
            document.Body = "Тіло контракту...";
            document.Footer = "Директор: Іванов І.І.";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
