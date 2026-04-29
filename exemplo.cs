class exemplo
{
    public int x {get; set;}
    public int y {get; set;}
    public int z {get; set;}

    public void Descobrir_Triangulo()
    {

        if ((x < y + z) && (y < x + z) && (z < x + y))
        {
            if((x == y) && (y == z))
            {
                Console.WriteLine("Triângulo Equilátero");
            }else if((x==y) || (x == z) || (y == z)){
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os Valores não formam um triangulo");
        }
    }
}