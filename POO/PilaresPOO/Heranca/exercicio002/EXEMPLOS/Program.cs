using EXEMPLOS;
using Microsoft.Win32.SafeHandles;


// Pessoa paulo = new Pessoa();

// paulo.Nome = "Paulo Vieira";
// paulo.Idade = 17;

// paulo.FazerSom();
// paulo.Mover();
// paulo.Dormir();

// Gato birobinha = new Gato();
// Cachorro toto = new Cachorro();


ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo incial da conta: r$ {cc.Saldo}");
cc.depositar(0.5);
Console.WriteLine($"Saldo Apos deposito: R$ {cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo Apos o saque: R${cc.Saldo}");



cc.Sacar(10);