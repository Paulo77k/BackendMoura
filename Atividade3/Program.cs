using System;

class Program
{
    static void Main()
    {
        // Solicita as medidas dos lados do triângulo
        Console.Write("Digite o valor do primeiro lado: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        double lado3 = double.Parse(Console.ReadLine());

        // Primeiro, verifica se as medidas formam um triângulo válido
        if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
        {
            // Verifica o tipo de triângulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triângulo Equilátero: possui os 3 lados iguais.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Triângulo Isósceles: possui 2 lados iguais.");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno: possui 3 lados diferentes.");
            }
        }
        else
        {
            Console.WriteLine("As medidas informadas não formam um triângulo válido!");
        }

        // Aguarda o usuário antes de encerrar
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

