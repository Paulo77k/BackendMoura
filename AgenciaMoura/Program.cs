int opcao;
int TotalCliente = 0;
String[] nomes = new string[3];
int[] idades = new int[3];
do
{
    Console.WriteLine($"==== Sistemas Bancario Simples ====");
    Console.WriteLine($"1)Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5)Listar Clientes");
    Console.WriteLine($"0) Sair");
    opcao = int.Parse("Console.ReadLine");
    Console.WriteLine($"Pressione ENTER para entrar");


    switch (opcao)
    {
        case 1:
            CadastarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;

        case 0:
            sair();
            break;
    }
} while (opcao != 0);



void CadastarCliente()
{
    Console.WriteLine("==== Cadastro de Cliente ====");
    if (TotalCliente >= 3)

    {
        Console.WriteLine("Limite de Vagas atingido");
        return;
    }
    Console.WriteLine("Digite o nome do Cliente");
    nomes[TotalCliente] = Console.ReadLine();

    Console.WriteLine("Digite a idade de {nomes[TotalCliente]}");
    idades[TotalCliente] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o Cpf do Cliente");
    idades[TotalCliente] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o Rg do Cliente");
        idades[TotalCliente] = int.Parse(Console.ReadLine());
    

    TotalCliente++;
    Console.WriteLine("Cliente Cadastrado com sucesso!");
}
void Depositar()
{
    Console.WriteLine($"Voce ira depositar?");

    Console.WriteLine($"Qual o Valor o Cliente Ira depositar?");
    idades[TotalCliente] = int.Parse(Console.ReadLine());
    TotalCliente++;
    Console.WriteLine($"Deposito Realizado Com Sucesso!");
    

}
void Sacar()
{
Console.WriteLine($"Voce ira realizar um Saque?");

}
void Transferir()
{
Console.WriteLine($"Voce ira Realizar uma Transferir?");

}
void ListarClientes()
{
 Console.WriteLine($"==== Listagem de Clientes ====");
  
    for (int i = 0; i < nomes.Length; i++)
    {
        if (TotalCliente >= 3)
        {
            Console.WriteLine("Nome: {nomes[i]}, {idades[i]} anos");
        }
    }
}
void sair()
{
    Console.WriteLine($"==== Voce Deseja Sair? ====");
    
}