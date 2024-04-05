namespace novo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area(); 
            Console.WriteLine("digite a base:");
            area.Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite a altura:");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Escolha: \n-Quadrado \n-retangulo \n-triangulo ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            
            area.Escolha(opcao);
        }
    }
}