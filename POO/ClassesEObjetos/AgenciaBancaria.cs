using System.Diagnostics.Contracts;

namespace ClassesEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular;
        public float Saldo;
        public void Depositar (float valor)
    
    {
            Saldo += valor;
Console.WriteLine($"Deposito efetuado com sucesso!");
            Console.WriteLine($"Saldo atualizado: {Saldo}");



    }
    

    public void Sacar(float valor)
        {
            if(valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
            Console.WriteLine($"Saque realizado com sucesso!");
            Console.WriteLine($"Novo Saldo: {Saldo}");  
            }
          Console.WriteLine($"Saldo insuficiente!");
          
            
             
        }
    
    }
}