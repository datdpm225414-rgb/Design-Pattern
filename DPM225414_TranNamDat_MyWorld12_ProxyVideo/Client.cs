using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_MyWorld12_ProxyVideo
{
    public class Client
    {
        static void Main(string[] args)
        {
            Video image = new ProxyVideo("Design Pattern.mp4");
            image.Display();
            Console.WriteLine("After loading first time\n");
            image.Display();
        }
    }
}
