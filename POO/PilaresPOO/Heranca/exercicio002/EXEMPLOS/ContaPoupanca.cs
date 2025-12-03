namespace EXEMPLOS
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;
        private double TaxaSaque = 3;

        public ContaPoupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
        }


        public override void depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor do deposito deve ser positivo");
                return;
                
            }
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            throw new NotImplementedException();
        }

    }
}