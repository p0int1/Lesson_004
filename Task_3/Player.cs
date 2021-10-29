using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Проигрываю музыку");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза воспроизведения");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Стоп воспроизведения");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Записываю звук");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Пауза записи");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Стоп записи");
        }

    }
}
