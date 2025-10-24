using System;

class Program
{
    static void Main()
    {
        // Define a senha correta
        int senhaCorreta = 1234;

        // Pede para o usuário digitar a senha
        Console.Write("Digite a senha: ");
        int senhaDigitada = int.Parse(Console.ReadLine());

        // Verifica se a senha é válida
        if (senhaDigitada == senhaCorreta)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }

        // Aguarda o usuário antes de encerrar
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

