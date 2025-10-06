namespace DPM225452_DoanTrongNhan_MyWorld17_Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);
            m.Colleague1 = c1;
            m.Colleague2 = c2;
            c1.Send("Look at this");
            c2.Send("It's amazing!");
            
           
        }
    }
}