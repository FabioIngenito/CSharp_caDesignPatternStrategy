using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - IRPF: Imposto de Renda Pessoa Física
    /// 
    /// O IRPF é imposto que recai sobre as rendas das pessoas físicas que tenham tido uma renda acima do teto estabelecido pela Receita que atualmente tem a faixa de tributação mensal acima de R $1.903,98 Uma vez por ano as pessoas físicas devem enviar suas declarações de rendimento para Receita Federal, onde é verificado a coerência no pagamento dos impostos.
    /// 
    /// Após a verificação desses dados pela receita, é possível receber a restituição do imposto de renda.
    /// </summary>
    internal class IRPF : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - IRPF: Imposto de Renda Pessoa Física
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.04;
        }
    }
}
