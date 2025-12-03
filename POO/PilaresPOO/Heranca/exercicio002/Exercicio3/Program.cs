using Exercicio3;



{
    
}
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.NumeroDePortas = 4;

        Moto moto = new Moto();
        moto.Marca = "Honda";
        moto.Modelo = "CG 160";
        moto.TipoCapacete = "Fechado";

        carro.MostrarInfo();
        Console.WriteLine();
        moto.MostrarInfo();

        Console.ReadLine();
    }
}