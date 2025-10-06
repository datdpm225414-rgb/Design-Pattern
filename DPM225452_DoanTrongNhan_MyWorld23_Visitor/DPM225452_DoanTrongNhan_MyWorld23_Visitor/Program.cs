
using DPM225452_DoanTrongNhan_MyWorld23_Visitor;
namespace DPM225452_DoanTrongNhan_MyWorld23_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> products = new List<IProduct>
        {
            new Book(100),
            new Clothing(200)
        };

            IVisitor taxCalculator = new TaxCalculatorVisitor();

            foreach (var product in products)
            {
                product.Accept(taxCalculator);
            }
        }
    }
}