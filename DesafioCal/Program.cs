int numero1 ;
int numero2 ;

Console.WriteLine("digite o primeiro numero:");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");

numero2 = int.Parse(Console.ReadLine());
int soma = numero1 + numero2;
Console.WriteLine($"A soma de {numero1} + {numero2} e {soma}");