namespace PilaresPOO
{
    public class AnimaiseSons
    {
        
    }
    
        

class Animal
{
    public void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

class Cachorro : Animal
{
    public new void FazerSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato : Animal
{
    public new void FazerSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main()
    {
        // Criando objetos
        Animal animal = new Animal();
        Cachorro cachorro = new Cachorro();
        Gato gato = new Gato();

        // Chamando os métodos
        animal.FazerSom();   // Mostra: O animal faz um som.
        cachorro.FazerSom(); // Mostra: Au au!
        gato.FazerSom();     // Mostra: Miau!

        // Também funciona se usarmos o tipo da classe base
        Animal outro = new Cachorro();
        outro.FazerSom(); // Mostra: O animal faz um som. (porque sem virtual não há polimorfismo)
    }
}

    }
