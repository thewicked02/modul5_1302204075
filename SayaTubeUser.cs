using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace modul5_1302204075
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;

        public SayaTubeUser(String username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();

            try
            {
                if (username.Length > 100) throw new Exception("Panjang username tidak boleh lebih dari 100");
                this.Username = checked(username);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                if (username == "") throw new Exception("username tidak boleh null");
                this.Username = checked(username);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
                total = total + uploadedVideos[i].getPlayCount();

            return total;
        }

        public void AddVideo(SayaTubeVideo a)
        {
            Contract.Requires(a != null);
            try
            {
                if (a == null) throw new Exception("Video tidak boleh null");
                uploadedVideos.Add(a);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        public void PrintAllVideoPlaycount()
        {

            Console.WriteLine("User : " + this.Username);
            try
            {
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    if (i > 7) throw new Exception("Print Hanya dapet 8 kali");
                    Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadedVideos[i].getTitle());

                }



            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }


            Console.WriteLine();
            Console.WriteLine("Total playCount : " + GetTotalVideoPlayCount());

        }
    }
}

