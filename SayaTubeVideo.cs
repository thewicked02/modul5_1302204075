using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204075
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;

            this.playCount = 0;
        }
        public void IncreasePlayCount(int a)
        {
            this.playCount += a;
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public String getTitle()
        {
            return this.title;
        }

        public void PrintVideoDetails()
        {
            for (int i = 0; i < playCount; i++)
            {

                Console.WriteLine("ID Video : " + this.id);
                Console.WriteLine("Title Video : " + this.title);
                Console.WriteLine("Playcount Video : " + (i + 1));
                Console.WriteLine();
            }
        }
    }
}
