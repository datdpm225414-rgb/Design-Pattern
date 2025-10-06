namespace DPM225452_DoanTrongNhan_MyWorld22_Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
        }
    }
}