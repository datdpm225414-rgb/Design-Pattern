namespace DPM225452_DoanTrongNhan_Pattern20_State { 
public class Program
{
    public static void Main(string[] args)
    {
        
        var context = new Context(new ConcreteStateA());
    
        context.Request();
        context.Request();
        context.Request();
        context.Request();
    }
}
}