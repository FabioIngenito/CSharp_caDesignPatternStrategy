using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO ESTADUAL:
    /// - IPVA: Imposto sobre Propriedade de Veículos Automotores
    /// 
    /// O Imposto sobre Propriedade de Veículos Automotores incide sobre a posse de veículos e sua alíquota é definida pelos seus respectivos estados.
    /// </summary>
    internal class IPVA : IImpostos
    {
        /// <summary>
        /// IMPOSTO ESTADUAL:
        /// - IPVA: Imposto sobre Propriedade de Veículos Automotores
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.11;
        }
    }
}
