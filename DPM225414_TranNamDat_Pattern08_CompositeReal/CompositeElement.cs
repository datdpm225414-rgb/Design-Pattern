using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DPM225414_TranNamDat_Pattern08_CompositeReal
{
     public class CompositeElement : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public CompositeElement(string name)
            : base(name)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
                "+ " + name);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}
