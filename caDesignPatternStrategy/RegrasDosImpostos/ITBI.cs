using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO MUNICIPAL:
    /// - ITBI: Imposto de Transmissão de Bens Imóveis
    /// 
    /// O Imposto de Transmissão de Bens Imóveis está previsto no Inciso II do Artigo 156. A alíquota deste imposto pode variar de acordo os municípios chegando até a 3% sobre o valor da base de cálculo, que neste caso seria o valor de venda definido pelo governo para o imóvel.
    /// 
    /// Acesse agora o site da Contabilizei, contabilidade on-line, conheça nossos serviços, planos, e veja também como abrir sua empresa gratuitamente.
    /// </summary>
    internal class ITBI : IImpostos
    {
        /// <summary>
        /// IMPOSTO MUNICIPAL:
        /// - ITBI: Imposto de Transmissão de Bens Imóveis
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.15;
        }
    }
}
