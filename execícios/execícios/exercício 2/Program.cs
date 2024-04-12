namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Joel";
            p.DataNasc = new DateTime(1993, 6, 28, 12, 02, 00);
            p.Altura = 1.76f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}