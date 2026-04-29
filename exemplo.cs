class exemplo
{
    public char resp {get; set;}

    public void pergunta()
    {
        Console.Write("Deseja Continuar (s/n): ");
        resp = char.Parse(Console.ReadLine());
    }
}