namespace Exercicio3
{
    public class Veiculo
    {
        public string Marca;
    public string Modelo;

    public virtual void MostrarInfo()
    {
        Console.WriteLine("Veículo:");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
    }
    }
}