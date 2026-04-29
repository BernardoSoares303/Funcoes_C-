class Program
{
    public static void Main()
    {
        exemplo ex = new exemplo();

        Console.Write("Insira o valor de X: ");
        ex.x = int.Parse(Console.ReadLine());

        Console.Write("Insira o valor de y: ");
        ex.y = int.Parse(Console.ReadLine());

        Console.Write("Insira o valor de z: ");
        ex.z = int.Parse(Console.ReadLine());

        ex.Descobrir_Triangulo();
    }
}