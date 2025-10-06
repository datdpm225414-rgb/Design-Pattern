namespace DPM225452_DoanTrongNhan_MyWorld20_State
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var context = new Context(new RedState());

            context.Request();
            context.Request();
            context.Request();

        }
    }
}