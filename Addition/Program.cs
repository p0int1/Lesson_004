using System;
//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Требуется: Изменить 12 пример первого урока (работа с документом) и создать общий абстрактный класс 
//для всех частей документа. 

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Задача");
            document.Body = "Описание задачи: Переписать конвееры на сервисы.";
            document.Footer = "Начальник: Белкин Д.И.";

            document.Show();

            Console.ReadKey();
        }
    }
}
