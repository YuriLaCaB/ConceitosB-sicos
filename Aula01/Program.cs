// See https://aka.ms/new-console-template for more information
using Aula01.NovaPasta;
using Aula01._1bim;
using System.Runtime.InteropServices;
using System.Drawing;

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.Write("[0] Sair\n[1] Somar dois numeros\n[2] Converter metros para milímetros\n[3] Aumento\n[4] Desconto\n[5] Aluguel de carro\n[6] Calculo de IMC\n[7] Tabuada Digite\n[8] Múltiplos de 3 entre 0 e 10\n[9] Fatoriais de 1 até 10\n[10] Imposto de renda\n[11] Adivinhar Número\n[12] Financiamento de veículo \n[13] Aposentadoria\nDigite: ");
    try
    {
        opcao = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Digite um valor válido");
        continue;
    }
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Saindo...");
            continuar = false;
            break;
        case 1:
            Soma();
            break;
        case 2:
            Conversor();
            break;
        case 3:
            AumentoSalarial();
            break;
        case 4:
            Desconto();
            break;
        case 5:
            AluguelVeiculo();
            break;
        case 6:
            IMC();
            break;
        case 7:
            Tab();
            break;
        case 8:
            mult();
            break;
        case 9:
            fatorial();
            break;
        case 10:
            Imposto();
            break;
        case 11:
            AdivinharNumero jogo = new AdivinharNumero();
            jogo.Adivinhacao();
            break; 
        case 12:
            FinanciarVeiculo();
            break;
        case 13:
            Aposentadoria(); 
            break;
        default:
            Console.WriteLine("Opção inválida ");
            break;
    }
}

void Soma()
{
        SomaDeDoisNumeros somador = new SomaDeDoisNumeros();
        int num1, num2;
        try
        {
            Console.Write("Número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            num2 = int.Parse(Console.ReadLine());
            int resultado = somador.somar(num1, num2);
            Console.WriteLine($"A soma dos números é: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Número não inteiro!");
        }
}

void Conversor()
{
    Console.Write("Digite em metros: ");
    double metros;
    try
    {
        metros = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Error");
        return;
    }
    MetrosMilimetros mtomm = new MetrosMilimetros();
    Console.WriteLine($"{metros}m  = {mtomm.metroparamilimetro(metros)}mm");
}

void AumentoSalarial()
{
    CalculoAumento calcamento = new CalculoAumento();
    double salAtual, aumentoPercent;
    Console.Write("Salário atual: ");
    try
    {
        salAtual = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }

    Console.Write("Aumento em porcentagem: ");
    try
    {
        aumentoPercent = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.WriteLine($"Salário antigo: {salAtual}\nAumento: {aumentoPercent}%\nValor do aumento: {salAtual * aumentoPercent / 100}\nNovo salário: {calcamento.calcularAumento(salAtual, aumentoPercent)}");
}

void Desconto()
{
    CalculoDesconto desc = new CalculoDesconto();
    double precoIni, descont;
    Console.Write("Preço inical: ");
    try
    {
        precoIni = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.Write("Desconto em porcentagem: ");
    try
    {
        descont = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.WriteLine($"Preço antigo: {precoIni}\nDesconto: {descont}%\nValor do desconto: {precoIni * descont / 100}\nNovo preço: {desc.calcDesconto(precoIni, descont)}");
}

void AluguelVeiculo()
{
    AluguelCarro aluguelCarro = new AluguelCarro();
    int totDias;
    double kmIni, kmFim;
    Console.Write("Total de dias: ");
    try
    {
        totDias = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.Write("Quilometragem inicial: ");
    try
    {
        kmIni = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.Write("Quilometragem final: ");
    try
    {
        kmFim = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.WriteLine($"Valor a ser pago: {aluguelCarro.aluguel(totDias, kmIni, kmFim)}");
}

void IMC()
{
    CalculoIMC calcIMC = new CalculoIMC();
    double massa, altura;
    Console.Write("Sexo: ");
    string sexo = Console.ReadLine();
    Console.Write("Peso (kg): ");
    try
    {
        massa = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.Write("Altura (m): ");
    try
    {
        altura = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    double resultadoIMC = calcIMC.calcularIMC(altura, massa);
    if (resultadoIMC < 18.5) Console.WriteLine("Abaixo do peso");
    else if (resultadoIMC < 24.9) Console.WriteLine("Peso ideal");
    else if (resultadoIMC < 29.9) Console.WriteLine("Levemente acima do peso");
    else if (resultadoIMC < 34.9) Console.WriteLine("Obesidade grau I");
    else if (resultadoIMC < 39.9) Console.WriteLine("Obesidade grau II");
    else Console.WriteLine("Obesidade III");
}

void Tab()
{
    Tabuada tabuadaLocal = new Tabuada();
    int num1;
    Console.Write("Número: ");
    try
    {
        num1 = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    for (int i = 0; i <= 10; i++) {
        Console.WriteLine($"{num1} * {i} = {tabuadaLocal.multiplicacao(num1, i)}");
    }
}

void mult()
{
    MultiplosDeTres multiplolocal = new MultiplosDeTres();
    int num1 = 0;
    for (int i = 0; i < 3; i++)
    {
        int numero = multiplolocal.Multiplos(num1);
        Console.WriteLine(" n" + (i + 1) + " = " + numero);
        num1 = numero;
    }
}
void fatorial()
{
    FatorialDosNumeros fatorialocal = new FatorialDosNumeros();

    for (int i = 1; i < 11; i++)
    {
        int numero = fatorialocal.FatorialNum(i);
        Console.WriteLine(numero);
    }
}
void Imposto()
{
    int dependente;
    double renda;
    Console.Write("Quantos dependentes há: ");
    try
    {
        dependente = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.Write("Qual a sua renda: ");
    try
    {
        renda = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    ImpostoDeRenda impostolocal = new ImpostoDeRenda();
    double imposto = impostolocal.Imposto(dependente, renda);
    Console.WriteLine($"o valor cobrado: R${imposto}");
}

void FinanciarVeiculo()
{
    double financiado, entrada, preco;
    Console.Write("\nDigite o preço do carro: R$");
    try
    {
        preco = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    Console.Write("Digite o preço de entrada: R$");
    try
    {
        entrada = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    do
    {
        Console.Write("Digite o valor financiado: R$");
        try
        {
            financiado = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("O valor deve ser um número!");
            return;
        }

        if (financiado + entrada != preco)
        {
            Console.WriteLine("Digite o número certo do valor financiado. ");
        }
    } while (financiado + entrada != preco);
    int parcela;
    Console.Write("Digite o número de parcela(s)[mensal]: ");
    try
    {
        parcela = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    float juros;
    Console.Write("Digite os juros mensais: ");
    try
    {
        juros = float.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    FinanciamentoDeVeiculo finaciado = new FinanciamentoDeVeiculo();
    double Valor = finaciado.FinanciamentoDeAutomovel(financiado, parcela, juros);
    Console.WriteLine($"\nO valor do carro: R${preco:F2}");
    Console.WriteLine($"O valor de entrada: R${entrada:F2}");
    Console.WriteLine($"O valor do financiamento: R${financiado:F2}");
    Console.WriteLine($"O valor da parcela: R${Valor:F2}");
    Console.WriteLine($"O valor total a ser pago do valor financiado: R${Valor * parcela:F2}\n");
}

void Aposentadoria()
{
    Console.Write("\nDigite seu nome: ");
    string nome = Console.ReadLine();
    int idade;
    Console.Write("Informe sua idade: ");
    try
    {
        idade = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    int tempoContribuicao;
    Console.Write("Digite seu tempo de contribuição (em anos): ");
    try
    {
        tempoContribuicao = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    double mediaSalarial;
    Console.Write("Digite sua média salarial (desde 1994): R$");
    try
    {
        mediaSalarial = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor deve ser um número!");
        return;
    }
    FileName aposentar = new FileName();
    double ValorAposentadoria = aposentar.Aposentar(idade, tempoContribuicao, mediaSalarial);
    Console.WriteLine($"O valor da aposentadoria[mensalmente]: R${ValorAposentadoria:F2}");
}