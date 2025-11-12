namespace Construtores
{
    public class Retangulo
    {
        public double largura;
    public double altura;

    
    public Retangulo(double l, double a)
    {
        largura = l;
        altura = a;
    }

   
    public Retangulo()
    {
        largura = 1;
        altura = 1;
    }

   
    public double CalcularArea()
    {
        return largura * altura;
    }

   
    static void Main()
    {
        
        Retangulo r1 = new Retangulo(5, 3);
        Console.WriteLine("Área do retângulo r1: " + r1.CalcularArea());

        
        Retangulo r2 = new Retangulo();
        Console.WriteLine("Área do retângulo r2: " + r2.CalcularArea());
    }
    }
}