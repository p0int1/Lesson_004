using System;
//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется:
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void
//Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
//Написать программу, которая выполняет проигрывание и запись.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player instance = new Player();

            // функции воспроизведения
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Функции воспроизведения\n" + new string('-', 30));
            IPlayable play = instance;
            play.Play();
            play.Pause();
            play.Stop();

            //функции записи
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nФункции записи\n" + new string('-', 30));
            IRecodable rec = instance;
            rec.Record();
            rec.Pause();
            rec.Stop();

            Console.ReadKey();
        }
    }
}
