// See https://aka.ms/new-console-template for more information
using Calculadora;

Console.WriteLine("Hello, World!");
Console.Clear();
Calculator calc = new Calculator();
calc.numero1 = 50;
calc.numero2 = 10;



Console.WriteLine($"==== Seja bem Vindo a Calculadora!");
int opcao = -1;
do
{
    Console.WriteLine($"Menu de opcoes!");
    Console.WriteLine($"0. entrar ");
    Console.WriteLine($"1. somar");
    Console.WriteLine($"2. subtrair");
    Console.WriteLine($"3. multiplicar");
    Console.WriteLine($"4. Dividir");
    Console.WriteLine($"Escolha uma opcao");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Voce escolheu Entrar");
            break;
        case 2:
            Console.WriteLine($"Resultado da soma: {calc.Somar()}");
            break;
        case 3:
            Console.WriteLine($"Resultado da subtracao: {calc.subtrair()}");
            break;
        case 4:
            Console.WriteLine($"Resultado da multiplicacao: {calc.Multiplicar()}");
            break;
        case 5:
            Console.WriteLine($"Resultado da divisao: {calc.Dividir()}");
            break;
            




    }







} while (opcao != 5);
Console.WriteLine($"Programa finalizado");


//Console.WriteLine($"== Calculator ==:");
//Console.WriteLine($"Primeiro numero: {calc.numero1}");
//Console.WriteLine($"Segundo numero: {calc.numero2}");


Console.WriteLine($"Resultados:");
Console.WriteLine($"");



Console.WriteLine($"Soma{calc.Somar()}");
calc.Somar();
Console.WriteLine($"");

Console.WriteLine($"Subtracao{calc.subtrair()}");
calc.subtrair();
Console.WriteLine($"");

Console.WriteLine($"Multiplicacao{calc.Multiplicar()}");
calc.Multiplicar();
Console.WriteLine($"");

Console.WriteLine($"Dividir{calc.Dividir()}");
calc.Dividir();
Console.WriteLine($"");







