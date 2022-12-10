using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine("Документ DOC создан");
        }

        public override void Open()
        {
            Console.WriteLine("Документ DOC открыт");
        }

        public override void Change()
        {
            Console.WriteLine("Документ DOC изменен");
        }

        public override void Save()
        {
            Console.WriteLine("Документ DOC сохранен");
        }
    }
}
