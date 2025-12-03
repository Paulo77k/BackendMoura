namespace EXEMPLOS
{
    public class Gato : Animal
    {
             public override void FazerSom()
        {
            Console.WriteLine($"miazinnzzz");
            
        }
        public override void Mover()
        {
            Console.WriteLine($"tuc tuc tuc");
            
        }
    }
}