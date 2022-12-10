using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название документа");
            string filename = Console.ReadLine();

            string extension = Path.GetExtension(filename);

            if(extension.Length == 0)
            {
                Console.WriteLine("Документ не найден");
            } else
            {
                if(extension == ".txt")
                {
                    TXTHandler txtHandler = new TXTHandler();
                    txtHandler.Create();
                    txtHandler.Open();
                    txtHandler.Change();
                    txtHandler.Save();
                } 
                else if(extension == ".xml")
                {
                    XMLHandler xmlHandler = new XMLHandler();
                    xmlHandler.Create();
                    xmlHandler.Open();
                    xmlHandler.Change();
                    xmlHandler.Save();
                }
                else if(extension == ".doc")
                {
                    DOCHandler docHandler = new DOCHandler();
                    docHandler.Create();
                    docHandler.Open();
                    docHandler.Change();
                    docHandler.Save();
                } else
                {
                    Console.WriteLine("Недопустимый формат");
                }
            }

            Console.ReadKey();
        }
    }
}
