using System.Diagnostics.Contracts;
using PrimeiraClasse;
Console.WriteLine($"======PROGRAMA PRIMEIRA CLASSE =====");

Carro mclaren = new Carro();
mclaren.marca = "mclaren";
mclaren.cor = "Roxo";
mclaren.modelo = "750s";
mclaren.portencia = 800;
Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");

mclaren.ligar();
 Console.WriteLine($"Acelerando a {mclaren.marca} {mclaren.cor}");
mclaren.acelerar();



Pessoa Paulo = new Pessoa();
Paulo.nome = "Paulo Vieira";
Paulo.idade = 17;
Paulo.Apelido = "Vieira";

Paulo.Chamar();
Paulo.Anos();


Garrafa Tuperware = new Garrafa();
Tuperware.cor = "roxa";
Tuperware.Capacidade = 500;
Tuperware.tamanho = 27;
Tuperware.formato = "Arredondada";
Tuperware.Abrir();
Tuperware.Beber();

Garrafa Stanley = new Garrafa();
Stanley.cor = "Azul Goiaba";
Stanley.Capacidade = 500;
Stanley.formato = "Cilindrico";
Stanley.tamanho = 20;
Console.WriteLine($"Abrindo Garrafa Stanley: ");
Stanley.Abrir();

Console.WriteLine($"Bebendo agua da Garrafa stanley: ");
Stanley.Beber();

Pessoa vieira = new Pessoa();
Console.WriteLine($"{vieira.nome} tem {vieira.idade} anos");
vieira.Envelhecer(10);
Console.WriteLine($"{vieira.nome} tem {vieira.idade} anos");




