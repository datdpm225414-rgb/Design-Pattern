using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld07_Bridge
{
    public class DrawingAPI1 : IDrawingAPI
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"API1: Vẽ hình tròn tại ({x}, {y}) bán kính {radius}");
        }
    }
}
