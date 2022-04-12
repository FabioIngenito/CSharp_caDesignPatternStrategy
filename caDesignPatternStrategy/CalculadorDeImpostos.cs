using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy
{
    internal class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImpostos imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
