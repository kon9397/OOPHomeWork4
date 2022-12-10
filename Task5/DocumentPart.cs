using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal abstract class DocumentPart
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
