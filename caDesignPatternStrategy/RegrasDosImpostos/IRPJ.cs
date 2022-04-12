using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - IRPJ: Imposto de Renda Pessoa Jurídica
    /// 
    /// Semelhante ao IRPF, porém esse incide sobre as pessoas jurídicas do país e pode ser feito de forma anual ou trimestral.
    /// 
    /// A alíquota pode variar de acordo com o modelo de tributação da empresa em questão, mas geralmente gira em torno de 15% do lucro nos casos onde a empresa fatura acima de R $20.000,00 por mês terá um adicional de 10%.
    ///
    /// Em alguns casos, como em fusões de empresas, pode acontecer um adicional de 10%. Isso acontece quando o lucro da empresa é maior que o valor de cada parcela multiplicado pela quantidade de meses e também maior que vinte mil reais.
    /// </summary>
    internal class IRPJ : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - IRPJ: Imposto de Renda Pessoa Jurídica
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
