namespace Construtores
{
    public class Carro
    {
   

    
    public string marca;
    public string modelo;
    public int ano;

    
    public Carro(string m, string mod, int a)
    {
        marca = m;
        modelo = mod;
        ano = a;

        Console.WriteLine("Carro criado!");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano: " + ano);
    }

    static void Main()
    {
       
        Carro meuCarro = new Carro("Fiat", "Uno", 2010);
    }
}

    }
