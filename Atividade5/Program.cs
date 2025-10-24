using System;

class Program
{
    static void Main()
    {
        // Pede ao usuário o número de maçãs compradas
        Console.Write("Digite o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco; // variável para armazenar o preço por maçã

        // Verifica o preço de acordo com a quantidade
        if (quantidade < 12)
        {
            preco = 0.30;
        }
        else
        {
            preco = 0.25;
        }

        // Calcula o valor total
        double total = quantidade * preco;

        // Exibe o valor total da compra
        Console.WriteLine($"O valor total da compra é: R$ {total:F2}");
    }
}
