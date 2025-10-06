using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld06_Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            InchLength lengthInInches = new InchLength(10);  
            IMetricLength lengthInCentimeters = new InchToCentimeterAdapter(lengthInInches);

            Console.WriteLine($"Length in inches: {lengthInInches.GetLengthInInches()}");
            Console.WriteLine($"Length in centimeters (via adapter): {lengthInCentimeters.GetLengthInCentimeters()}");

            Console.ReadKey();
        }
    }
}
