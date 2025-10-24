int n1;
int n2;


Console.WriteLine("digite o primeiro numero:");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O primeiro numero e o maior:{n1}");
}

else if (n1 > n2)

{
    Console.WriteLine($"O  segundo e o maior: {n2}");
}

else
{
    Console.WriteLine("Os numeros sao iguais!");
}