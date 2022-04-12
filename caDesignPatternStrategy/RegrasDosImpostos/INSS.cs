using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// - INSS: Instituto Nacional do Seguro Social
    /// 
    /// O imposto referente ao INSS é destinado a Previdência Social e é uma obrigação das pessoas jurídicas. O não recolhimento desse imposto pode acarretar em medidas como multas e uma série de problemas com a Receita Federal. 
    /// 
    /// Para empresas optantes pelo Simples Nacional o INSS é recolhido junto com a DAS.Já as empresas que optam pelo regime de lucro real ou pelo regime de lucro presumido recolhem a alíquota de 31%, sendo 11% do colaborador e 20% do empregador.
    /// 
    /// Para quem desempenha atividades como MEI o recolhimento se dá por meio da DAS-MEI e seu valor será correspondente a 5% sobre o salário mínimo, que agora em 2022 é de 5% sobre R$ 1.212,00. 
    /// </summary>
    internal class INSS : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// - INSS: Instituto Nacional do Seguro Social
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.09;
        }
    }
}
