// Visual Studio 2022
//
// Se você estranhou este arquivo, assim como eu estranhei, veja o o link abaixo:
// Modelo de aplicativo de console do .NET 6 C# gera instruções de nível superior
// Artigo - 06/04/2022 - 6 minutos para o fim da leitura
//
// A partir do .NET 6, o modelo de projeto para novos aplicativos de console em C# gera o seguinte código no arquivo Program. cs :
//
// https://docs.microsoft.com/pt-br/dotnet/core/tutorials/top-level-templates
// See https://aka.ms/new-console-template for more information
//
// Tutorial: explorar ideias usando instruções de nível superior para criar código conforme você aprende
// https://docs.microsoft.com/pt-br/dotnet/csharp/whats-new/tutorials/top-level-statements
//
// Eu já me adaptei a este formato no mínimo estranho, pois sou um "Programador Borg" (mas todo programador da Microsoft o é!) KKKKK!!!

using caFormaERRADA.Modelos;

Orcamento orca = new(1000.0);

//IMPOSTOS FEDERAIS
double valorII = CalculadorDeImpostos.RealizaCalculo(orca, "II");
double valorIOF = CalculadorDeImpostos.RealizaCalculo(orca, "IOF");
double valorIPI = CalculadorDeImpostos.RealizaCalculo(orca, "IPI");
double valorIRPF = CalculadorDeImpostos.RealizaCalculo(orca, "IRPF");
double valorIRPJ = CalculadorDeImpostos.RealizaCalculo(orca, "IRPJ");
double valorCOFINS = CalculadorDeImpostos.RealizaCalculo(orca, "COFINS");
double valorPIS = CalculadorDeImpostos.RealizaCalculo(orca, "PIS");
double valorCSLL = CalculadorDeImpostos.RealizaCalculo(orca, "CSLL");
double valorINSS = CalculadorDeImpostos.RealizaCalculo(orca, "INSS");
//IMPOSTOS ESTADUAIS
double valorICMS = CalculadorDeImpostos.RealizaCalculo(orca, "ICMS");
double valorIPVA = CalculadorDeImpostos.RealizaCalculo(orca, "IPVA");
double valorITCMD = CalculadorDeImpostos.RealizaCalculo(orca, "ITCMD");
//IMPOSTOS MUNICIPAIS
double valorIPTU = CalculadorDeImpostos.RealizaCalculo(orca, "IPTU");
double valorISS = CalculadorDeImpostos.RealizaCalculo(orca, "ISS");
double valorITBI = CalculadorDeImpostos.RealizaCalculo(orca, "ITBI");

//--------------------------------------
Console.WriteLine();
Console.WriteLine("Estes são os IMPOSTOS FEDERAIS:");
Console.WriteLine($"O valor do II é: {valorII}");
Console.WriteLine($"O valor do IOF é: {valorIOF}");
Console.WriteLine($"O valor do IPI é: {valorIPI}");
Console.WriteLine($"O valor do IRPF é: {valorIRPF}");
Console.WriteLine($"O valor do IRPJ é: {valorIRPJ}");
Console.WriteLine($"O valor do COFINS é: {valorCOFINS}");
Console.WriteLine($"O valor do PIS é: {valorPIS}");
Console.WriteLine($"O valor do CSLL é: {valorCSLL}");
Console.WriteLine($"O valor do INSS é: {valorINSS}");
Console.WriteLine();
Console.WriteLine("Estes são os IMPOSTOS ESTADUAIS:");
Console.WriteLine($"O valor do ICMS é: {valorICMS}");
Console.WriteLine($"O valor do IPVA é: {valorIPVA}");
Console.WriteLine($"O valor do ITCMD é: {valorITCMD}");
Console.WriteLine();
Console.WriteLine("Estes são os IMPOSTOS MUNICIPAIS:");
Console.WriteLine($"O valor do IPTU é: {valorIPTU}");
Console.WriteLine($"O valor do ISS é: {valorISS}");
Console.WriteLine($"O valor do ITBI é: {valorITBI}");

//--------------------------------------
Console.ReadKey();