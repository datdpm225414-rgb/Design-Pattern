namespace DPM225452_DoanTrongNhan_MyWorld19_Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "Nue"));
            s.Attach(new ConcreteObserver(s, "Nyn"));
            s.Attach(new ConcreteObserver(s, "Kai"));
            // Change subject and notify observers
            s.SubjectState = "On";
            s.Notify();
            // Wait for user
            Console.ReadKey();
        }
    }
}