using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy.RegrasDosImpostos
{
    /// <summary>
    /// IMPOSTO FEDERAL:
    /// -  IPI: Imposto sobre Produtos Industrializados 
    /// 
    /// O IPI pode incidir sobre todo tipo de produto industrializado assim que ele sai da fábrica.O percentual que incide sobre o valor do produto (alíquota) pode ser variável, conforme elencado na TIPI 2022: produtos essenciais como alimentos possuem alíquota menor que produtos supérfluos, e produtos como cigarro possuem uma alíquota mais elevada como forma de conter os danos à saúde da população.
    /// 
    /// Entretanto alguns produtos são isentos do imposto se são industrializados por instituições de educação ou para uso próprio. 
    ///
    /// Para calcular o IPI é necessário primeiro encontrar a base de cálculo: valor do produto + seguro + frete + demais despesas. Esse valor é multiplicado pela alíquota presente na Tabela de Incidência do Imposto sobre Produtos Industrializados
    /// </summary>
    internal class IPI : IImpostos
    {
        /// <summary>
        /// IMPOSTO FEDERAL:
        /// -  IPI: Imposto sobre Produtos Industrializados 
        /// </summary>
        /// <param name="orcamento">Classe Orçamento</param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.03;
        }
    }
}
