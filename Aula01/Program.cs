// See https://aka.ms/new-console-template for more information
using Aula01.NovaPasta;
using Aula01._1bim;
using System.Runtime.InteropServices;

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.Write("[0] Sair\n[1] Somar dois numeros\n[2] Converter metros para milímetros\nDigite: ");
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
