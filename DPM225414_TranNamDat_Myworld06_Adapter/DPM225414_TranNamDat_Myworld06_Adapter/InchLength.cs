using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld06_Adapter
{
    public class InchLength
    {
        private double inches;

        public InchLength(double inches)
        {
            this.inches = inches;
        }

        public double GetLengthInInches()
        {
            return inches;
        }
    }
}
