namespace Construtores
{
    public class construtor
    {
        public string Nome;
        public int idade;
        public construtor(String n, int i, string xpto)
        {
            Console.WriteLine($"Classe construtor foi construida!");
            Nome = n;
            idade = i;
            Console.WriteLine($"Seu texto e: {xpto}");

        }
        public construtor(string n, int i)
        {
            Nome = n;
            idade = i;
        }
        public construtor(string n)
        {
            Nome = n;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome{Nome}, iadade {idade}");

        }


    }
}