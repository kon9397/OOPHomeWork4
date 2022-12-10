using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine("Документ XML создан");
        }

        public override void Open()
        {
            Console.WriteLine("Документ XML открыт");
        }

        public override void Change()
        {
            Console.WriteLine("Документ XML изменен");
        }

        public override void Save()
        {
            Console.WriteLine("Документ XML сохранен");
        }
    }
}
