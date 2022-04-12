

namespace caDesignPatternStrategy.Modelos
{
    /// <summary>
    /// Modelos de Classe Orçamento.
    /// </summary>
    public class Orcamento
    {
        internal double Valor { get; private set; }

        /// <summary>
        /// Construtor da Classe Orçamento.
        /// </summary>
        /// <param name="valor">Valor do orçamento em unidades monetárias.</param>
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
