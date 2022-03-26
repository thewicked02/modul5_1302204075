using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

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

            Contract.Requires(title != null);
            Contract.Requires(title.Length > 200);

            try
            {
                if (title.Length > 200) throw new Exception("Panjang title tidak boleh lebih dari 200");
                this.title = checked(title);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                if (title == "") throw new Exception("Title tidak boleh null");
                this.title = checked(title);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


        }
        public void IncreasePlayCount(int a)
        {
            Contract.Requires(a <= 25000000);
            try
            {
                if (a > 25000000) throw new Exception("Play Count tidak boleh lebih dari 25.000.000");
                this.playCount += checked(a);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }

            Contract.Requires(a > 0);
            try
            {
                if (a < 0) throw new Exception("Play Count tidak boleh mines");
                this.playCount += checked(a);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
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
            Console.WriteLine("ID Video : " + this.id);
            Console.WriteLine("Title Video : " + this.title);
            Console.WriteLine("Playcount Video : " + this.playCount);
            Console.WriteLine();
        }
    }
}

