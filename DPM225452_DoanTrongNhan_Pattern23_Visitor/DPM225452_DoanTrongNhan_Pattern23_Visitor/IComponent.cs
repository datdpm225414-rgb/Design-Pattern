using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225452_DoanTrongNhan_Pattern23_Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
