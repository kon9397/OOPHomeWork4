using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Игра началась");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Запись остановлена");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Игра остановлена");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Игра закончена");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Запись закончена");
        }
        public void Record()
        {
            Console.WriteLine("Запись начата");
        }


    }
}
