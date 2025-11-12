namespace PrimeiraClasse
{
    public class Pessoa
    {


        public string nome;
        public int idade = 0;
        public string Apelido;

        public void Anos()
        {
            Console.WriteLine($"quantos Anos voce tem?{idade}");

        }
        public void Nome()
        {
            Console.WriteLine($"Qual e o seu Nome?{nome}");

        }
        public void Chamar()
        {
            Console.WriteLine($"Como costumam te chamar? {Apelido}");

        }
        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                idade += _id;
            }
            else
            idade++;
      
        }
   
    }

}