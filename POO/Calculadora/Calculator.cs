namespace Calculadora
{
    public class Calculator

    {
        public double numero1;
        public double numero2;

        public double resultado;

        public double Somar()
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"Resultado da soma: {resultado}");
            return resultado;

        }
        public double subtrair()
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"Resulado da subtracao: {resultado}");
            return resultado;
        }
        public double Multiplicar()
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"Restultado da Multiplicacao: {resultado}");
            return resultado;
        }
        public double Dividir()
        {
            if (numero2 == 0)
            {
                Console.WriteLine($"Nao existe divisao por zero");
                return 0;
            }
            resultado = numero1 / numero2;
            Console.WriteLine($"Resultado da divisao");
            return resultado;

        }

 public string opcao = "";


    }

}