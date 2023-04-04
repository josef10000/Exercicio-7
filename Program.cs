namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número do vendedor: ");
            int numeroVendedor = int.Parse(Console.ReadLine());
            Console.Write("Digite o salário fixo do vendedor: R$ ");
            double salarioFixo = double.Parse(Console.ReadLine());
            Console.Write("Digite o total de vendas por ele efetuadas: R$ ");
            double totalVendas = double.Parse(Console.ReadLine());
            Console.Write("Digite o percentual que ganha sobre o total de vendas: ");
            double percentualComissao = double.Parse(Console.ReadLine());

            // Cálculo do salário total do vendedor
            double salarioTotal = salarioFixo + totalVendas * percentualComissao / 100;

            // Exibição dos resultados
            Console.WriteLine("Número do vendedor: {0}", numeroVendedor);
            Console.WriteLine("Salário total do vendedor: R$ {0:0.00}", salarioTotal);

            Console.ReadKey();
        }
    }
}