using Calculadora;

int escolhaOperacao, sairDoPrograma = 1;
double primeiroNumero, segundoNumero;

Console.WriteLine("Seja bem-findo a sua calculadora!\n");

while (sairDoPrograma == 1)
{
    Console.WriteLine("Que operação você deseja fazer?\n " +
        "1 - Soma \n " +
        "2 - Subtração \n " +
        "3 - Multiplicação \n " +
        "4 - Divisão");
    Console.WriteLine("\nEscolha:");
    escolhaOperacao = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 1º número:");
    primeiroNumero = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o 2º número:");
    segundoNumero = Convert.ToDouble(Console.ReadLine());

    Operacoes operacao = new Operacoes(primeiroNumero, segundoNumero, escolhaOperacao);

    Console.WriteLine($"\nResultado: {operacao.ExibirResultado()}");
    Console.WriteLine("\nDeseja continuar?\n " +
        "1 - Sim \n " +
        "2 - Não");
    sairDoPrograma = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}
