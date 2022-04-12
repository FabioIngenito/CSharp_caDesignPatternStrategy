namespace caFormaERRADA.Modelos;

/// <summary>
/// lISTA DE iMPOSTOS:
/// - Impostos Federais: IOF, II, IPI, IRPF, IRPJ, Cofins, PIS / Pasep, CSLL, INSS.
/// - Impostos Estaduais: ICMS, IPVA, ITCMD.
/// - Impostos Municipais: IPTU, ISS, ITBI.
/// 
/// https://www.contabilizei.com.br/contabilidade-online/impostos-federais-estaduais-e-municipais/?utm_source=adwords&utm_medium=ppc&utm_campaign=%5BMAX%5D_Performance_RMKT_CWB&utm_term=&hsa_tgt=&hsa_grp=&hsa_mt=&hsa_cam=14463419940&hsa_ver=3&hsa_src=x&hsa_net=adwords&hsa_kw=&hsa_acc=1466761651&hsa_ad=&gclid=CjwKCAjwo8-SBhAlEiwAopc9W-Fw1OVAM3J2KUegr1da2Gy2Pt2xXkddoeBcOBl7EJHc9fwIOQJ6DxoCgK8QAvD_BwE
/// </summary>
internal static class CalculadorDeImpostos
{
    //ATENÇÃO: cada IMPOSTO tem um cálculo MUITO mais complexo que este mero exemplo.

    /// <summary>
    /// Função ÚNICA para calcular TODOS os impostos.
    /// 
    /// ATENÇÃO: cada IMPOSTO tem um cálculo MUITO mais complexo que este mero exemplo.
    /// </summary>
    /// <param name="orcamento">class Orçamento</param>
    /// <param name="imposto">Tipo do Imposto</param>
    /// <returns></returns>
    internal static double RealizaCalculo(Orcamento orcamento, String imposto)
    {
        double valor = 0;

        // A string está na frente do ".Equals" para NÃO ocorrer erro de objeto nulo,
        // desta forma em caso de nulo o retorno será zero.
        if ("II".Equals(imposto))
        {
            valor = orcamento.Valor * 0.01;
        }
        else if("IOF".Equals(imposto))
        {
            valor = orcamento.Valor * 0.02;
        }
        else if ("IPI".Equals(imposto))
        {
            valor = orcamento.Valor * 0.03;
        }
        else if ("IRPF".Equals(imposto))
        {
            valor = orcamento.Valor * 0.04;
        }
        else if ("IRPJ".Equals(imposto))
        {
            valor = orcamento.Valor * 0.05;
        }
        else if ("COFINS".Equals(imposto))
        {
            valor = orcamento.Valor * 0.06;
        }
        else if ("PIS".Equals(imposto))
        {
            valor = orcamento.Valor * 0.07;
        }
        else if ("CSLL".Equals(imposto))
        {
            valor = orcamento.Valor * 0.08;
        }
        else if ("INSS".Equals(imposto))
        {
            valor = orcamento.Valor * 0.09;
        }
        else if ("ICMS".Equals(imposto))
        {
            valor = orcamento.Valor * 0.1;
        }
        else if ("IPVA".Equals(imposto))
        {
            valor = orcamento.Valor * 0.11;
        }
        else if ("ITCMD".Equals(imposto))
        {
            valor = orcamento.Valor * 0.12;
        }
        else if ("IPTU".Equals(imposto))
        {
            valor = orcamento.Valor * 0.13;
        }
        else if ("ISS".Equals(imposto))
        {
            valor = orcamento.Valor * 0.14;
        }
        else if ("ITBI".Equals(imposto))
        {
            valor = orcamento.Valor * 0.15;
        }

        return valor;
    }
}
