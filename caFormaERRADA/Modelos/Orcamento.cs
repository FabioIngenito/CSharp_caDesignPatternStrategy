namespace caFormaERRADA.Modelos
{
    /// <summary>
    /// Modelos de Classe Orçamento
    /// </summary>
    internal class Orcamento
    {
        internal double Valor { get; private set; }

        /// <summary>
        /// Construtor da Classe Orçamento
        /// </summary>
        /// <param name="valor">Valor do orçamento em unidades monetárias</param>
        internal Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}
