// See https://aka.ms/new-console-template for more information
using Aula01.NovaPasta;
using Aula01._1bim;
using System.Runtime.InteropServices;

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.Write("[0] Sair\n[1] Somar dois numeros\n[2] Converter metros para milímetros\n[3] Aumento\n[4] Desconto\n[5] Aluguel de carro\n[6] Calculo de IMC\n[7] Tabuada Digite\n[8]Múltiplos de 3 entre 0 e 10\n[9]Fatoriais de 1 até 10\n[10]Imposto de renda\nDigite: ");
    opcao = int.Parse(Console.ReadLine());
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
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void Soma()
{
    SomaDeDoisNumeros somador = new SomaDeDoisNumeros();
    int num1, num2;
    Console.Write("Número 1: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Número 2: ");
    num2 = int.Parse(Console.ReadLine());
    int resultado = somador.somar(num1, num2);
    Console.WriteLine($"A soma dos números é: {resultado}");
}

void Conversor()
{
    Console.Write("Digite em metros: ");
    double metros = double.Parse(Console.ReadLine());
    MetrosMilimetros mtomm = new MetrosMilimetros();
    Console.WriteLine($"{metros}m  = {mtomm.metroparamilimetro(metros)}mm");
}

void AumentoSalarial()
{
    CalculoAumento calcamento = new CalculoAumento();
    Console.Write("Salário atual: ");
    double salAtual = double.Parse(Console.ReadLine());
    Console.Write("Aumento em porcentagem: ");
    double aumentoPercent = double.Parse(Console.ReadLine());
    Console.WriteLine($"Salário antigo: {salAtual}\nAumento: {aumentoPercent}%\nValor do aumento: {salAtual*aumentoPercent/100}\nNovo salário: {calcamento.calcularAumento(salAtual, aumentoPercent)}");
}
void Desconto()
{
    CalculoDesconto desc = new CalculoDesconto();
    Console.Write("Preço inical: ");
    double precoIni = double.Parse(Console.ReadLine());
    Console.Write("Desconto em porcentagem: ");
    double descont = double.Parse(Console.ReadLine());
    Console.WriteLine($"Preço antigo: {precoIni}\nDesconto: {descont}%\nValor do desconto: {precoIni * descont / 100}\nNovo preço: {desc.calcDesconto(precoIni, descont)}");
}

void AluguelVeiculo()
{
    AluguelCarro aluguelCarro = new AluguelCarro();
    Console.Write("Total de dias: ");
    int totDias = int.Parse(Console.ReadLine());
    Console.Write("Quilometragem inicial: ");
    double kmIni = double.Parse(Console.ReadLine());
    Console.Write("Quilometragem final: ");
    double kmFim = double.Parse(Console.ReadLine());
    Console.WriteLine($"Valor a ser pago: {aluguelCarro.aluguel(totDias, kmIni, kmFim)}");
}

void IMC()
{
    CalculoIMC calcIMC = new CalculoIMC();
    Console.Write("Sexo: ");
    string sexo = Console.ReadLine();
    Console.Write("Peso (kg): ");
    double massa = double.Parse(Console.ReadLine());
    Console.Write("Altura (m): ");
    double altura = double.Parse(Console.ReadLine());
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
    Console.Write("Número: ");
    int num1 = int.Parse(Console.ReadLine());
    for (int i = 0; i <= 10; i++) Console.WriteLine($"{num1} * {i} = {tabuadaLocal.multiplicacao(num1, i)}");
}
void mult()
{
    MultiplosDeTres multiplolocal = new MultiplosDeTres();
    int num1 = 0;
    for (int i = 0; i < 3; i++)
    {
        int numero = multiplolocal.Multiplos(num1);
        Console.WriteLine(" n"+(i+1)+" = "+numero);
        num1=numero;
    }   
}
void fatorial()
{
    FatorialDosNumeros fatorialocal = new FatorialDosNumeros();

    for (int i = 1; i < 11; i++)
    {   
        int numero= fatorialocal.FatorialNum(i);
        Console.WriteLine(numero);
    }
}
void Imposto()
{
    int valor,renda;
    Console.WriteLine("Qual a porcentagem do imposto de renda:  ");
    valor=int.Parse(Console.ReadLine());
    Console.WriteLine("Qual a sua renda: ");
    renda=int.Parse(Console.ReadLine());
    ImpostoDeRenda impostolocal = new ImpostoDeRenda();
    double imposto = impostolocal.Imposto(valor,renda);
    Console.WriteLine($"o valor cobrado: R${imposto}");

}

/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem-vindo(a) {nome}");
Console.WriteLine("Informe sua idade: ");
try
{
    int idade = int.Parse(Console.ReadLine());
    if ( idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    Console.WriteLine("A idade informada foi " + idade);
    if (idade % 2 == 0)
    {
        Console.WriteLine("A idade informada corresponde a um número par!");
    }
    else
    {
        Console.WriteLine("A idade informada corresponde a um número ímpar!");
    }
    string primo = "";
    for (int i = 2; i <= idade / 2; i++)
    {
        if (idade % i == 0)
        {
            primo = "não ";
            break;
        }
    }
    Console.WriteLine($"A idade {primo} corresponde a um número primo");
}
catch(FormatException e)
{
    Console.WriteLine("A idade digitada não corresponde a um número inteiro");
}

catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Não se sabe se um é primo ou não!");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido, contate o desenvolvedor.");
}
*/
