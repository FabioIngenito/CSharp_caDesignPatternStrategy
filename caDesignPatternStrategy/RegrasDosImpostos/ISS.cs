using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO MUNICIPAL:
    /// - ISS: Imposto Sobre Serviços
    /// 
    /// O ISS é recolhido pelos municípios e Distrito Federal e incide sobre os serviços elencados na Lei 11.438/1997 e a Lei Complementar 116/2003. Uma breve lista dos serviços inclui, mas não se restringem a: serviços veterinários, de informática, de reparo, de engenharia, planos de saúde, etc.
    ///
    /// Para quem é MEI o valor do imposto já está incluso na DAS-MEI.
    /// </summary>
    internal class ISS : IImpostos
    {
        /// <summary>
        /// IMPOSTO MUNICIPAL:
        /// - ISS: Imposto Sobre Serviços
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.14;
        }
    }
}
