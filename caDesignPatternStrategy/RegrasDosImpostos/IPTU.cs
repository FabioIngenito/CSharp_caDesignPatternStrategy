using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO MUNICIPAL:
    /// IPTU: Imposto Predial e Territorial Urbano
    /// 
    /// O Imposto Predial e Territorial Urbano é o imposto ligados as propriedades presentes no meio urbano e cobrado anualmente pelos municípios dos proprietários de casas, prédios e estabelecimentos comerciais.
    /// 
    /// O imposto é cobrado por propriedade e não por contribuinte, o que significa que se um contribuinte possui dez imóveis, ele pagará dez IPTUs.
    /// 
    /// Podemos citar ainda relacionados a este imposto outros dois: o ITU (Imposto sobre Território Urbano) e o ITR(Imposto sobre Território Rural). Que incidem sobre terrenos vazios em território urbano e a propriedades rurais fora do perímetro urbano.
    /// 
    /// O IPTU é reajustado anualmente considerando a valorização da propriedade e pelo valor de venda e pode ser pago a vista ou em parcelas.
    /// </summary>
    internal class IPTU : IImpostos
    {
        /// <summary>
        /// IMPOSTO MUNICIPAL:
        /// IPTU: Imposto Predial e Territorial Urbano
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13;
        }
    }
}
