namespace Construtores
{
    public class Aluno
    {
        
         public string nome;
    public double nota;

    
    public Aluno()
    {
        nome = "Sem nome";
        nota = 0.0;

        Console.WriteLine("Aluno criado (valores padrão):");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Nota: " + nota);
        Console.WriteLine();
    }

    
    public Aluno(string n, double nt)
    {
        nome = n;
        nota = nt;

        Console.WriteLine("Aluno criado (valores informados):");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Nota: " + nota);
        Console.WriteLine();
    }

    
    static void Main()
    {
       
        Aluno aluno1 = new Aluno();

        
        Aluno aluno2 = new Aluno("João", 9.0);
    }
    }
}