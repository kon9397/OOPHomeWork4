using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            IRecordable recorder = new Player();
            player.Play();
            recorder.Record();
            player.Pause();
            recorder.Pause();
            player.Stop();
            recorder.Stop();


            Console.ReadKey();
        }
    }
}
