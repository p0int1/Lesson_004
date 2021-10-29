using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    abstract class PartDoc
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
