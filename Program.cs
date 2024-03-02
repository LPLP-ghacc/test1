public class Program
{
    public static void Main()
    {
        double a = 377;
        double b = 120;

        double c = a / b;

        for(int i = 0; i < int.MaxValue; i++)
        {
            c += 1;
        }

        Console.WriteLine(c);
    }
}