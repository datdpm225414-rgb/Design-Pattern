using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225452_DoanTrongNhan_MyWorld23_Visitor
{
    public class TaxCalculatorVisitor:IVisitor
    {
        public void Visit(Book book)
        {
            double tax = book.GetPrice() * 0.05;
            Console.WriteLine($"Tax for book: {tax:C}");
        }

        public void Visit(Clothing clothing)
        {
            double tax = clothing.GetPrice() * 0.10;
            Console.WriteLine($"Tax for clothing: {tax:C}");
        }
    }
}
