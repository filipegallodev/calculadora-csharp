using Calculadora;

int escolhaOperacao;
double primeiroNumero, segundoNumero;

Console.WriteLine("Seja bem-findo a sua calculadora!\n");

Console.WriteLine("Que operação você deseja fazer?\n 1 - Soma");
Console.WriteLine("\nEscolha:");
escolhaOperacao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite o 1º número:");
primeiroNumero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nDigite o 2º número:");
segundoNumero = Convert.ToDouble(Console.ReadLine());

Operacoes operacao = new Operacoes(primeiroNumero, segundoNumero, escolhaOperacao);

Console.WriteLine($"\nResultado: {operacao.ExibirResultado()}");

Console.ReadLine();
