using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld04_Prototype
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Phương thức clone
        public abstract Shape Clone();

        public void Display()
        {
            Console.WriteLine($"Shape: {this.GetType().Name}, Width: {Width}, Height: {Height}");
        }
    }
}
