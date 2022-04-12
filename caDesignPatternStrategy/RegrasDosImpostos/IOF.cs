using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - IOF: Imposto sobre Operações Financeiras 
    /// 
    /// Este imposto possui diversos tipos de taxas para cada tipo de operação financeira sobre a qual ele incide e também está em alteração constante, de acordo a decisão do governo brasileiro.
    /// 
    /// No cartão de crédito, por exemplo, o IOF só incide em caso de atraso de pagamento da fatura. Os bancos cobram uma taxa de 0,38% com acréscimo de 0,0082% por dia de atraso até a dívida ser completamente abatida. Essa é a mesma taxa que incide sobre empréstimos e financiamentos.
    ///
    /// Já para compras feitas fora do país essa taxa sobre para 6,38%.
    /// </summary>
    internal class IOF : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - IOF: Imposto sobre Operações Financeiras 
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.02;
        }
    }
}
