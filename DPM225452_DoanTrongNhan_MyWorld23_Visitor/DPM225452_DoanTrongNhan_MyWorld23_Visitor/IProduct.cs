using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225452_DoanTrongNhan_MyWorld23_Visitor
{
    public interface IProduct
    {
        void Accept(IVisitor visitor);
        double GetPrice();
    }
}
