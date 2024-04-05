namespace areaquadradoretangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Calculo da Area");
            Area area = new Area();
            Console.WriteLine("digite o valor da Base:");
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o valor da Altura:");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Area:" + area.Calcular());
            Console.WriteLine("Area:" + area.Calcular2());

            area.MostraDetalhes();





        }
    }
}