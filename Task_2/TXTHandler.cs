using System;

namespace Task_2
{
    class TXTHandler : AbstractHandler
    {
        public string FileName { get; set; }

        public override void Open()
        {
            Console.WriteLine("Открыт текстовый файл: " + FileName);
        }
        public override void Create()
        {
            Console.WriteLine("Создан текстовый файл: " + FileName);
        }
        public override void Change()
        {
            Console.WriteLine("Изменен текстовый файл: " + FileName);
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен текстовый файл: " + FileName);
        }
    }
}
