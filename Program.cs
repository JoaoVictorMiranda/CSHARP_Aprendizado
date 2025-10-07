using System.Reflection;

namespace CSHARP_APRENDIZADO;

class Program
{
    static void Main(string[] args)
    {
        /*Implementar um programa em Java para calcular o valor final de uma compra a
        partir do valor da compra e do cupom de desconto. O cupom diz quantos reais
        terá de desconto.*/

        Console.WriteLine(" PROGRAMA DO DESCONTO ");
        Console.Write("Digite o valor do produto: ");
        int preco = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor do Desconto: ");
        int desconto = Convert.ToInt32(Console.ReadLine());

        double ValorFinal = Descontar(preco, desconto);

        Console.WriteLine($"O valor final ficou em ${ValorFinal}");

    }

    public static double Descontar(double Valor, double Desconto)
    {
        double ValorFinal = Valor - Desconto;
        return ValorFinal;
    }






}
