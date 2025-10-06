using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225452_DoanTrongNhan_MyWorld23_Visitor
{
    public class Clothing:IProduct
    {
        public double Price { get; }
        public Clothing(double price)
        {
            Price = price;
        }
        public double GetPrice() => Price;
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
