using System;

namespace Task_2
{
    class XMLHandler : AbstractHandler
    {
        public string FileName { get; set; }

        public override void Open()
        {
            Console.WriteLine("Открыт XML файл: " + FileName);
        }
        public override void Create()
        {
            Console.WriteLine("Создан XML файл: " + FileName);
        }
        public override void Change()
        {
            Console.WriteLine("Изменен XML файл: " + FileName);
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен XML файл: " + FileName);
        }
    }
}
