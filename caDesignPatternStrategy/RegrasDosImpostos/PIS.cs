using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - PIS: Programa de Integração Social
    /// 
    /// O Programa de Integração Social é um imposto que é recolhido junto ao Cofins, por isso muitas vezes são confundidos ou considerados a mesma coisa.Porém, enquanto o Cofins se destina a seguridade social, o PIS é destinado ao pagamento do abono salarial de mesmo nome.
    /// 
    /// O PIS segue as mesmas regras de recolhimento cumulativo ou não cumulativo da Cofins. Sendo que na primeira modalidade inclui-se junto a Cofins a alíquota de 0,65% e na segunda modalidade soma-se a alíquota de 1,65%. 
    /// 
    /// Para importações acrescenta-se a alíquota de 2,1%
    /// </summary>
    internal class PIS : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - PIS: Programa de Integração Social
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }
    }
}
