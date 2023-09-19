using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainDrop1
{
    internal class GameEngine
    {
        int frame;
        int fps;

        Cloud cloud = new Cloud();
        Wind wind = new Wind();

        public void Start()
        {
            var chrono = new Stopwatch();
            chrono.Start();
            while (true)
            {
                Console.Write($"FPS:{fps}");

                //TODO  make elements move
                cloud.Live(wind);
                wind.Live();
                
                Thread.Sleep(100);
                Console.Clear();
                frame++;
                if(chrono.ElapsedMilliseconds > 1000 )
                {
                    fps = frame;
                    frame = 0;
                    chrono.Restart();
                } 
            }
        }
    }
}
