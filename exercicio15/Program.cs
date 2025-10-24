int n1;
int n2;
int n3;
int n4;

Console.WriteLine("digite o primeiro numero:");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("digite o terceiro numero:");
n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto numero");
n4 = int.Parse(Console.ReadLine());

if (n1 > n2) ;
{
    Console.WriteLine($"A primeira nota e a maior:{n1}");
}
 if (n2 > n1) ;
  Console.WriteLine($"A segunda nota e a maior:{n2}");

if (n3 > n2) ;
 Console.WriteLine($"A terceira nota e a maior:{n3}");

if (n4 > n3) ;
 Console.WriteLine($"A quarta nota e a maior:{n4}");

