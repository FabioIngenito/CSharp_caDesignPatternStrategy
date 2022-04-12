using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO ESTADUAL:
    /// - ITCMD - Chamado de Imposto sobre a Transmissão Causa Mortis e Doação
    /// 
    /// Chamado de Imposto sobre a Transmissão Causa Mortis e Doação é um imposto que deve ser pago nas situações de transmissão de heranças ou doações. Os contribuintes são descritos nas leis dos seus respectivos estados, assim como a alíquota. 
    /// 
    /// A alíquota entretanto, possui um valor máximo de 8%, firmado pelo Sena
    /// </summary>
    internal class ITCMD : IImpostos
    {
        /// <summary>
        /// IMPOSTO ESTADUAL:
        /// - ITCMD - Chamado de Imposto sobre a Transmissão Causa Mortis e Doação
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            //switch (orcamento.Valor)
            //{
            //    case < 1000 :
            //        return orcamento.Valor * 0.05;

            //    case < 3000 :
            //        return orcamento.Valor * 0.07 + 30;

            //    case >= 3000 :
            //        return orcamento.Valor * 0.08;

            //    default:
            //        return 0;
            //}

            return orcamento.Valor * 0.12;
        }
    }
}
