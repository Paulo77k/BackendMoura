using System;


class Funcionario
{
    public string Nome;
    public double SalarioBase;

    public double CalcularSalario()
    {
        return SalarioBase;
    }
}


class Gerente : Funcionario
{
    public double Bonus;

 
    public new double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}


class App
{
    static void Main()
    {
        Funcionario f = new Funcionario();
        f.Nome = "João";
        f.SalarioBase = 3000;

        Gerente g = new Gerente();
        g.Nome = "Maria";
        g.SalarioBase = 5000;
        g.Bonus = 1500;

        Console.WriteLine("Funcionário: " + f.Nome + " | Salário: " + f.CalcularSalario());
        Console.WriteLine("Gerente: " + g.Nome + " | Salário: " + g.CalcularSalario());
    }
}
