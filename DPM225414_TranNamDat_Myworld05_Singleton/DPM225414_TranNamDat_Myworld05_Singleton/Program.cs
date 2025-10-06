using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld05_Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            if (logger1 == logger2)
            {
                Console.WriteLine("logger1 và logger2 là cùng một instance");
            }

            logger1.Log("Ứng dụng bắt đầu");
            logger2.Log("Ứng dụng đang chạy");

            Console.ReadKey();
        }
    }
}
