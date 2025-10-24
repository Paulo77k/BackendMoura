int escolha;
do
{
    Console.WriteLine($"Mister Big pizza");

    Console.WriteLine("------------------------------------");
    Console.WriteLine("           Bem vindo                ");
    Console.WriteLine("              ao                    ");
    Console.WriteLine("Mister Big pizza");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("qual opcao voce deseja escolher?");
    Console.WriteLine("Pizza de Mussarela");
    Console.WriteLine("Pizza de calabresa");
    Console.WriteLine("Pizza Portguesa");
    Console.WriteLine("Pizza de 4 queijos");
    Console.WriteLine("Pizza de Parmegiana");
    Console.WriteLine("Sair");

    escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Voce escolheu Pizza de Mussarela!");
            break;

        case 2:
            Console.WriteLine("Voce escolheu Pizza de Calabresa!");
            break;

        case 3:
            Console.WriteLine("Voce escolheu Pizza Portuguesa!");
            break;

        case 4:
            Console.WriteLine("Voce escolheu Pizza de 4 queijos!");
            break;

        case 5:
            Console.WriteLine("Voce escolheu Pizza de Parmegiana!");
            break;
    }
} while (escolha != 4);

void PizzaMussarela()
{
    Console.WriteLine("Voce escolheu Pizza de Mussarela!");
}
void PizzaCalabresa()
{
    Console.WriteLine("Voce escolheu Pizza de Calabresa!");
}
void PizzaPortugues()
{
    Console.WriteLine("Voce escolheu Pizza Portuguesa!");
}
void Pizza4queijo()
{
    Console.WriteLine("Voce escolheu Pizza de 4 queijos!");
}
void PizzaParmegiana()
{
         Console.WriteLine("Voce escolheu Pizza de Parmegiana!");
}
    
