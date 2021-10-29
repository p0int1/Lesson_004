using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Detector
    {
        AbstractHandler handler;

        public void DetectDocument(string file)
        {
            string[] extension = file.Split(".");

            switch (extension[1])
            {
                case "txt":
                    handler = new TXTHandler { FileName = file };
                    break;
                case "doc":
                    handler = new DOCHandler { FileName = file };
                    break;
                case "xml":
                    handler = new XMLHandler { FileName = file };
                    break;
                default:
                    Console.WriteLine("Ошибка распознования");
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Craete()
        {
            handler.Create();
        }

        public void Change()
        {
            handler.Change();
        }

        public void Save()
        {
            handler.Save();
        }
    }
}
