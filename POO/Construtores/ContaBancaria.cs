namespace Construtores
{
    public class ContaBancaria
    {
        
    public string titular;
    public double saldo;

    
    public ContaBancaria(string t, double s)
    {
        titular = t;
        saldo = s;
    }

   
    public ContaBancaria(string t)
    {
        titular = t;
        saldo = 0.0;
    }

    
    public void MostrarDados()
    {
        Console.WriteLine("Titular: " + titular);
        Console.WriteLine("Saldo: " + saldo);
        Console.WriteLine();
    }

    
    static void Main()
    {
        
        ContaBancaria conta1 = new ContaBancaria("Maria", 500.0);
        conta1.MostrarDados();

        
        ContaBancaria conta2 = new ContaBancaria("João");
        conta2.MostrarDados();
    }
    }

}