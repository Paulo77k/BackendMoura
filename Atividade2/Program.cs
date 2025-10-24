//2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
using System;

class Program
{
    static void Main()
    {
        // Solicita os gols do primeiro time
        Console.Write("Digite o número de gols do primeiro time: ");
        int golsTime1 = int.Parse(Console.ReadLine());

        // Solicita os gols do segundo time
        Console.Write("Digite o número de gols do segundo time: ");
        int golsTime2 = int.Parse(Console.ReadLine());

        // Verifica o resultado
        if (golsTime1 > golsTime2)
        {
            Console.WriteLine("Vitória do primeiro time!");
        }
        else if (golsTime2 > golsTime1)
        {
            Console.WriteLine("Vitória do segundo time!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }

        // Espera o usuário pressionar uma tecla antes de encerrar
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
