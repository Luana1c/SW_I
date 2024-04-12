namespace exercicio_4
{
    class Program
    {
      
            static void Main(string[] args)
            {
                Console.WriteLine("Digite as informações do funcionário:");

                Funcionario funcionario = new Funcionario();

                Console.Write("Nome: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Salário: ");
                funcionario.Salario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Horas Extras Diurnas: ");
                funcionario.HED = Convert.ToInt32(Console.ReadLine());

                Console.Write("Horas Extras Noturnas: ");
                funcionario.HEN = Convert.ToInt32(Console.ReadLine());

                Console.Write("Número de Dependentes: ");
                funcionario.ND = Convert.ToInt32(Console.ReadLine());

                Console.Write("Faltas em Horas: ");
                funcionario.FAL = Convert.ToInt32(Console.ReadLine());

                Console.Write("Descontos Eventuais: ");
                funcionario.DE = Convert.ToDouble(Console.ReadLine());

                Console.Write("Gastos com Refeições: ");
                funcionario.REF = Convert.ToDouble(Console.ReadLine());

                Console.Write("Vales Retirados: ");
                funcionario.VAL = Convert.ToDouble(Console.ReadLine());

               
                funcionario.ImprimirFolhaPagamento();
            }
        }
    
    }