int opcao;
int TotalCliente = 0;
float[] saldos = new float[10];
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
    opcao = int.Parse(Console.ReadLine());
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
     // validar se há espaço pra cadastrar no array
    if (TotalCliente >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido!");
        return;
    }

    // cadastrar o cliente no array
    Console.Write($"Nome do cliente: ");
    nomes[TotalCliente] = Console.ReadLine();//cadastra o nome do cliente
    saldos[TotalCliente] = 0;//inicia o saldo zerado
    TotalCliente++;//incrementa a variável de controle de clientes
    Console.WriteLine("Cliente cadastrado com sucesso!");
}
void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1) {
        return;
    }
    Console.WriteLine($"Valor para deposito: ");
    float Valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += Valor;
    Console.WriteLine($"Deposito de R$ {Valor:F2} realizado");
    


    

}
void Sacar()
{
Console.WriteLine($"Voce ira realizar um Saque?");
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.WriteLine($"Valor para saque: ");
    float Valor = float.Parse(Console.ReadLine());
    if (saldos[idCliente] >= Valor)
    {
        saldos[idCliente] = saldos[idCliente] - Valor;
        saldos[idCliente] -= Valor;
        Console.WriteLine($"Saque realizado com sucesso!");

    }
    else
    {
        Console.WriteLine($"Saldo insuficiente!");

    }
    if (saldos[idCliente] >= Valor && Valor > 0)
    {
        Console.WriteLine($"Saque realizado com Sucesso!");
        
    }
    
}
void Transferir()
{
Console.WriteLine($"Voce ira Realizar uma Transferencia?");
    Console.WriteLine($"Conta de Origem: ");
    int idOrigem = BuscarCliente();
    if (idOrigem == -1)  return;

    Console.WriteLine($"Conta de Destino: ");
    int idDestino = BuscarCliente();
    if (idDestino == -1)  return;
    Console.WriteLine($"Valor para transferir: ");
    float Valor = float.Parse(Console.ReadLine());

    if (saldos[idOrigem] >= Valor && Valor > 0)
    {
        saldos[idOrigem] -= Valor;
        saldos[idDestino] += Valor;
        Console.WriteLine($"transferencia concluida!");
        

    }
    else
    {
        Console.WriteLine($"Saldo insuficiente!");
        
    }

      
    
}
void ListarClientes()
{
 Console.WriteLine($"==== Listagem de Clientes ====");
  
   for (int i = 0; i < TotalCliente; i++)
   {
    Console.WriteLine($"{i}) - {nomes[i]} - {saldos[i]}");
    
   }
}
void sair()
{
    
}

int BuscarCliente()
{
    ListarClientes();
    Console.WriteLine($"Digite o numero do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 | idCliente >= TotalCliente)
    {
        Console.WriteLine($"Cliente nao encontrado!");
        return -1;

    }
    
    return idCliente;
}