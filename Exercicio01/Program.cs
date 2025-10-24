double salariorecebido, totalgasto;
Console.WriteLine("informe o salario: ");
salariorecebido = double.Parse(Console.ReadLine());
Console.WriteLine("informe o gasto do mes: ");
totalgasto = double.Parse(Console.ReadLine());

if (totalgasto > salariorecebido)
{
    Console.WriteLine("Orçamento Estourado!");
}
else
{
    Console.WriteLine("Gastos dentro do Orçamento");  
}