using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - II: Imposto sobre Importação
    ///
    /// Incide diretamente sobre mercadorias estrangeiras que entram no país, sejam eles comprados pela internet ou em viagem.Quem arca com este imposto sempre é o importador. 
    ///
    /// É calculado de acordo o que está previsto no Acordo Sobre a Implementação, com taxas variáveis.Sua função é apenas regulatória.
    /// </summary>
    internal class II : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - II: Imposto sobre Importação
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01;
        }
    }
}
