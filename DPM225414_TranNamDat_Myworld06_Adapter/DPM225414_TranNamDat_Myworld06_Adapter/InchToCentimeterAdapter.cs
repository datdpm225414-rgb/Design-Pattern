using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld06_Adapter
{
    public class InchToCentimeterAdapter : IMetricLength
    {
        private InchLength inchLength;

        public InchToCentimeterAdapter(InchLength inchLength)
        {
            this.inchLength = inchLength;
        }

        public double GetLengthInCentimeters()
        {
            // 1 inch = 2.54 cm
            return inchLength.GetLengthInInches() * 2.54;
        }
    }
}
