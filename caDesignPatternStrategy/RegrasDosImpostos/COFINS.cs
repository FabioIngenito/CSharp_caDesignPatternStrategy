using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - Cofins: Contribuição para Financiamento da Seguridade Social
    /// 
    /// A Contribuição para Financiamento da Seguridade Social foi criada em 1991, incide sobre todas as pessoas jurídicas do país(exceto as optantes do Simples Nacional) e é calculado sobre a receita bruta das empresas.Sua arrecadação é destinada a projetos de segurança social como aposentadoria, saúde pública, previdência social e programas de assistência social.
    /// 
    /// Embora seja pago junto ao imposto do PIS, esses são dois tributos diferentes e falaremos mais do segundo logo abaixo.
    /// 
    /// Existem duas formas de se calcular a sua Cofins:
    /// 
    /// 1. Pelo recolhimento cumulativo: Para as empresas que utilizam o regime de lucro presumido a alíquota é firmada em 3% e não são descontados os créditos tributários inclusos em despesas.
    /// 2. Pelo recolhimento não cumulativo: Este modelo é utilizado para as empresas que utilizam o regime de lucro real e aqui podem ser descontados os créditos tributários inclusos em despesas.Neste caso o valor do recolhimento fica em torno de 7,6%
    /// 
    /// Entretanto, no caso de pessoas jurídicas que trabalhe com importação a alíquota aplicada é de 9,65% para a Cofins-Importação.
    /// </summary>
    internal class COFINS : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - Cofins: Contribuição para Financiamento da Seguridade Social
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
