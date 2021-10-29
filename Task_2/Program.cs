using System;
//Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Требуется: Создайте класс AbstractHandler. 
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//Создать производные  классы  XMLHandler, TXTHandler, DOCHandler  от  базового  класса AbstractHandler. 
//Написать программу, которая будет выполнять определение документа и для каждого формата должны 
//быть методы открытия, создания, редактирования, сохранения определенного формата документа. 

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Detector detect = new Detector();

            detect.DetectDocument("readme.txt");
            detect.Open();
            detect.Change();
            detect.Save();
            Console.WriteLine(new string('-', Console.WindowWidth - 1));

            detect.DetectDocument("config.xml");
            detect.Open();
            detect.Save();
            Console.WriteLine(new string('-', Console.WindowWidth - 1));

            detect.DetectDocument("feature.doc");
            detect.Open();

            Console.ReadKey();
        }
    }
}
