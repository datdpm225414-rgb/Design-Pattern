namespace DPM225452_DoanTrongNhan_MyWorld18_Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "Exits";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Delete";

            o.SetMemento(c.Memento);
        }
    }
}