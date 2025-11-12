using ClassesEObjetos;
Garrafa stanley = new Garrafa();

Console.Clear();
Console.WriteLine($"== Agencia Bancaria ==");
Console.WriteLine($"");


AgenciaBancaria contadoVieira = new AgenciaBancaria();

contadoVieira.Titular = "Vieira";
contadoVieira.Saldo = 1000.98f;
contadoVieira.Depositar(500);
contadoVieira.Sacar(300);

