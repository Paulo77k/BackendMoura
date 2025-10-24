String[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0;

int opcao = -1;
do
{
    Console.WriteLine("==== Aplicativo Sala de aula ====");
    Console.WriteLine("1) Listar alunos");
    Console.WriteLine("2) Cadastrar Alunos");
    Console.WriteLine("0) Sair");
    Console.WriteLine("Escola uma opcao:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando ....");
            break;

        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
            break;
    }
    Console.WriteLine("Pressione <Enter> Para continuar ....");
    Console.ReadLine();
} while (opcao != 0);

void ListarAluno()

{
    Console.WriteLine("===== Listagem de Alunos =====");
    for (int i = 0; i < nomes.Length; i++)
    {
        if (totalAlunos >= 3)
        {
            Console.WriteLine("Nome: {nomes[i]}, {idades[i]} anos");
        }
    }

}




void CadastrarAluno()
{
    Console.WriteLine("==== Cadastro de Aluno ====");
    if (totalAlunos >= 3)

    {
        Console.WriteLine("Limite de Vagas atingido");
        return;
    }
    Console.WriteLine("Digite o nome do Aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine("Digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
    Console.WriteLine("Aluno Cadastrado com sucesso!");
}