string nome;
string sobrenome;
int idade;
float saldobancario;
float investimentos;

Console.WriteLine("Ola, qual e o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual e o seu sobrenome");
sobrenome = Console.ReadLine();

Console.WriteLine("qual a sua idade");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto voce tem de saldo bancario?");
saldobancario = float.Parse(Console.ReadLine());

Console.WriteLine("quais investimentos voce fez?");
investimentos = float.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("nome:" + nome);

Console.WriteLine("idade:" + idade);

Console.WriteLine("sobrenome::" + sobrenome);

Console.WriteLine("saldo bancario: R$" + saldobancario);

Console.WriteLine("Investimentos: R$" + investimentos);

