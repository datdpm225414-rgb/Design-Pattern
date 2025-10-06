using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld04_Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng gốc
            Rectangle rect1 = new Rectangle();
            rect1.Width = 100;
            rect1.Height = 50;

            // Clone đối tượng
            Rectangle rect2 = (Rectangle)rect1.Clone();
            rect2.Width = 200;  // Thay đổi thuộc tính riêng biệt trên bản clone

            // Hiển thị 2 đối tượng
            rect1.Display();  // Output: Shape: Rectangle, Width: 100, Height: 50
            rect2.Display();  // Output: Shape: Rectangle, Width: 200, Height: 50

            Console.ReadKey();
        }
    }
}
