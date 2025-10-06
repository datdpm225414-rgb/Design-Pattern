using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld07_Bridge
{
    public class Program
    {
        static void Main()
        {
            Shape circle1 = new CircleShape(1, 2, 3, new DrawingAPI1());

            circle1.Draw();

            circle1.ResizeByPercentage(2.5);
            circle1.Draw();

            Console.ReadKey();
        }
    }
}
