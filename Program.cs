using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //panggil object
            SayaTubeVideo stv = new SayaTubeVideo("Review Film Jigsaw oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv1 = new SayaTubeVideo("Review Film Divergen oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv2 = new SayaTubeVideo("Review Film Alegian oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv3 = new SayaTubeVideo("Review Film EEEEEEEE oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv4 = new SayaTubeVideo("Review Film Apes oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv5 = new SayaTubeVideo("Review Film RAWRRR oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv6 = new SayaTubeVideo("Review Film GRRRRRRR oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv7 = new SayaTubeVideo("Review Film BARK oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv8 = new SayaTubeVideo("Review Film MEOW oleh Rodo Idola Nathanael Marbun");
            SayaTubeVideo stv9 = new SayaTubeVideo("Review Film AUUUUU oleh Rodo Idola Nathanael Marbun");
            SayaTubeUser stu = new SayaTubeUser("Rodo Idola Nathanael Marbun");

            //menambahkan playcount dari setiap video
            stv.IncreasePlayCount(2);
            stv1.IncreasePlayCount(3);
            stv2.IncreasePlayCount(4);
            stv3.IncreasePlayCount(7);
            stv4.IncreasePlayCount(5);
            stv5.IncreasePlayCount(3);
            stv6.IncreasePlayCount(6);
            stv7.IncreasePlayCount(6);
            stv8.IncreasePlayCount(2);
            stv9.IncreasePlayCount(9);


            stu.AddVideo(stv1);

            stv1.PrintVideoDetails();

            stu.PrintAllVideoPlaycount();
        }
    }
}