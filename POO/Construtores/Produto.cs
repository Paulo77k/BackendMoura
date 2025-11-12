namespace Construtores
{
    public class Produto
    {
         public string nome;
    public double preco;
    public int estoque;

    
    public Produto(string n, double p, int e)
    {
        nome = n;
        preco = p;
        estoque = e;
    }

    
    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Estoque: " + estoque);
        Console.WriteLine(); // linha em branco
    }

    
    static void Main()
    {
        
        Produto produto1 = new Produto("Biscoito", 3.50, 20);

        
        produto1.MostrarDados();
    }
    }
}