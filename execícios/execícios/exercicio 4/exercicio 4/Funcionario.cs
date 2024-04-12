using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    using System;

    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int HED { get; set; }
        public int HEN { get; set; }
        public int ND { get; set; }
        public int FAL { get; set; }
        public double DE { get; set; }
        public double REF { get; set; }
        public double VAL { get; set; }

        public double CalcularHorasExtras()
        {
            return (HED * Salario / 160) + (HEN * 1.2 * Salario / 160);
        }

        public double CalcularSalarioFamilia(double salarioMinimo)
        {
            return ND * 0.05 * salarioMinimo;
        }

        public double CalcularSalarioBruto()
        {
            double horasExtras = CalcularHorasExtras();
            double salarioBruto = Salario + horasExtras + CalcularSalarioFamilia(1100); 
            return salarioBruto;
        }

        public double CalcularDescontoINAMPS()
        {
            return 0.08 * Salario;
        }

        public double CalcularDescontoFaltas()
        {
            return FAL * Salario / 160;
        }

        public double CalcularTotalDescontos()
        {
            return DE + REF + VAL + CalcularDescontoINAMPS() + CalcularDescontoFaltas();
        }

        public double CalcularImpostoRenda()
        {
            return 0.08 * CalcularSalarioBruto();
        }

        public double CalcularSalarioLiquido()
        {
            return CalcularSalarioBruto() - CalcularTotalDescontos() - CalcularImpostoRenda();
        }

        public void ImprimirFolhaPagamento()
        {
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("Salário: R$" + Salario);
            double horasExtras = CalcularHorasExtras();
            Console.WriteLine("Horas Extras: R$" + horasExtras);
            double salarioFamilia = CalcularSalarioFamilia(1100); 
            Console.WriteLine("Salário Família: R$" + salarioFamilia);
            double salarioBruto = CalcularSalarioBruto();
            Console.WriteLine("Salário Bruto: R$" + salarioBruto);
            double descontoINAMPS = CalcularDescontoINAMPS();
            Console.WriteLine("Desconto INAMPS: R$" + descontoINAMPS);
            double descontoFaltas = CalcularDescontoFaltas();
            Console.WriteLine("Desconto por Faltas: R$" + descontoFaltas);
            Console.WriteLine("Descontos Eventuais: R$" + DE);
            Console.WriteLine("Gastos com Refeições: R$" + REF);
            Console.WriteLine("Vales Retirados: R$" + VAL);
            double totalDescontos = CalcularTotalDescontos();
            Console.WriteLine("Total de Descontos: R$" + totalDescontos);
            double impostoRenda = CalcularImpostoRenda();
            Console.WriteLine("Imposto de Renda: R$" + impostoRenda);
            double salarioLiquido = CalcularSalarioLiquido();
            Console.WriteLine("Salário Líquido: R$" + salarioLiquido);
        }
    }

   
}
