using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO ESTADUAL:
    /// - ICMS: Impostos sobre circulação de mercadorias e serviços
    /// 
    /// O Imposto sobre a Circulação de Mercadorias e Serviços é o imposto com maior volume de arrecadação do Brasil, justamente pelo seu amplo fator gerador. Ele incide em todo tipo de produto e serviço prestado e é cobrado de forma indireta, tendo seu valor embutido nos bens de consumo ou no serviço prestado. 
    ///
    /// Para calcular esse imposto basta aplicar sua alíquota ao produto ou serviço em questão, entretanto é importante frisar que cada estado pratica uma alíquota diferente.Por isso é preciso verificar qual a alíquota correspondente em seu estado.
    /// 
    /// No caso de comércios interestaduais aplica-se o Diferencial de Alíquota (DIFAL) que visa reduzir a desigual arrecadação entre os dois estados envolvidos. 
    /// </summary>
    internal class ICMS : IImpostos
    {
        /// <summary>
        /// IMPOSTO ESTADUAL:
        /// - ICMS: Impostos sobre circulação de mercadorias e serviços
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
