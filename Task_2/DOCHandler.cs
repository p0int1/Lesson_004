using System;

namespace Task_2
{
    class DOCHandler : AbstractHandler
    {
        public string FileName { get; set;}
        
        public override void Open()
        {
            Console.WriteLine("Открыт doc файл: " + FileName);
        }
        public override void Create()
        {
            Console.WriteLine("Создан doc файл: " + FileName);
        }
        public override void Change()
        {
            Console.WriteLine("Изменен doc файл: " + FileName);
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен doc файл: " + FileName);
        }
    }
}
