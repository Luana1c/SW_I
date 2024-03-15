namespace ContariaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Banco da Luana!");

            Conta conta = new Conta();
            Console.WriteLine("CONSULTANDO O SALDO");
            conta.consuta_saldo();
            Console.WriteLine("deposito");
            conta.depositar(1000.35);
            Console.WriteLine("consulta o saldo!");
            conta.consuta_saldo();
           // Console.WriteLine("Sacar!");
           //conta.sacar(500);
           // Console.WriteLine("Consulta o saldo !");
           //conta.consuta_saldo();
           // Console.WriteLine("Saca o valor!");
           // conta.sacar(1000);


        }
    }
}