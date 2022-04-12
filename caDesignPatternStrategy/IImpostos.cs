using caDesignPatternStrategy.Modelos;

namespace caDesignPatternStrategy
{
    /// <summary>
    /// Qual a diferença entre impostos federais, estaduais e municipais?
    /// 
    /// - Impostos Federais: IOF, II, IPI, IRPF, IRPJ, Cofins, PIS / Pasep, CSLL, INSS.
    /// - Impostos Estaduais: ICMS, IPVA, ITCMD.
    /// - Impostos Municipais: IPTU, ISS, ITBI.
    /// 
    /// https://www.contabilizei.com.br/contabilidade-online/impostos-federais-estaduais-e-municipais/?utm_source=adwords&utm_medium=ppc&utm_campaign=%5BMAX%5D_Performance_RMKT_CWB&utm_term=&hsa_tgt=&hsa_grp=&hsa_mt=&hsa_cam=14463419940&hsa_ver=3&hsa_src=x&hsa_net=adwords&hsa_kw=&hsa_acc=1466761651&hsa_ad=&gclid=CjwKCAjwo8-SBhAlEiwAopc9W-Fw1OVAM3J2KUegr1da2Gy2Pt2xXkddoeBcOBl7EJHc9fwIOQJ6DxoCgK8QAvD_BwE
    /// </summary>
    public interface IImpostos
    {
        double Calcula(Orcamento orcamento);
    }
}
