public class Fibonacci
{
    int n = 20 ;
    int a = 0, b = 1;

    public void consolelog()
    {
        Console.WriteLine($"Os primeiros {n} números de Fibonacci:");
        
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}