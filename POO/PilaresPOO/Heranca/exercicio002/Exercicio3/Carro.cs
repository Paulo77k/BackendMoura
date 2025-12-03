namespace Exercicio3
{
    public class Carro : Veiculo
    {
         public int NumeroDePortas;

    public override void MostrarInfo()
    {
        Console.WriteLine("Carro:");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Número de portas: " + NumeroDePortas);
    }
    }
}