namespace Exercicio10
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ValorReal(double quantidadeDolar, double cotacaoDolar)
        {
            return (quantidadeDolar + (quantidadeDolar * Iof))  * cotacaoDolar;
        }
    }
}
