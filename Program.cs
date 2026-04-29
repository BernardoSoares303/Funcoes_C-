class Program
{
    public static void Main()
    {
        exemplo ex = new exemplo();
        Fibonacci fibonacci = new Fibonacci();
        do
        {
            ex.pergunta();
        }while(ex.resp != 'n');

        fibonacci.consolelog();
    }
}