using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - CSLL: Contribuição Social sobre Lucro Líquido
    /// 
    /// A Contribuição Social sobre Lucro Líquido é instituída pela lei n° 7.689/1988 e incide sobre todas as pessoas jurídicas do país.As regras aplicadas para apuração são as mesmas do Imposto de Renda de Pessoa Jurídica(IRPJ) que falamos acima.
    /// 
    /// Entretanto a alíquota e a periodicidade podem variar de acordo o regime de tributação da empresa: 
    /// 
    /// Simples Nacional: Pelo Nacional o recolhimento acontece mensalmente pela guia do DAS, sem seguir as alíquotas de 9% ou 15%, as alíquotas de CSLL no simples nacional pode variar de 0,27% á 0,54% sobre o faturamento.
    /// 
    /// - Lucro Real: Neste caso a apuração acontece a cada três meses, após os rendimentos do período serem apurados e são ajustadas pelo LALUR (Livro de Apuração do Lucro Real).
    /// - Lucro Presumido: Neste regime a tributação também acontece trimestralmente.Após ser apurado o faturamento do período utiliza-se a alíquota de presunção do lucro que pode ser de até 32% para serviços gerais e 12% para o ramo imobiliário, industrial, comercial ou hospitalar.Em seguida aplica-se sobre o valor encontrado na presunção a alíquota de 9% ou 15% para encontrar o valor a ser pago.
    /// 
    /// Para quem é MEI, esse imposto está incluso na guia DAS-MEI.
    /// </summary>
    internal class CSLL : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - CSLL: Contribuição Social sobre Lucro Líquido
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08;
        }
    }
}
