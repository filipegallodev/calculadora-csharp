namespace Calculadora
{
    public class Operacoes
    {
        public Operacoes(double primeiroNumero, double segundoNumero, int escolhaOperacao)
        {
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
            EscolhaOperacao = escolhaOperacao;
        }

        public double PrimeiroNumero { get; set; }
        public double SegundoNumero { get; set; }
        public int EscolhaOperacao { get; set; }

        public double ExibirResultado()
        {
            switch (EscolhaOperacao)
            {
                case 1: 
                    return Somar();
                case 2: 
                    return Substrair();
                case 3:
                    return Multiplicar();
                case 4:
                    return Dividir();
                default:
                    return 0.0;
            }
        }
        public double Somar()
        {
            return PrimeiroNumero + SegundoNumero;
        }
        public double Substrair()
        {
            return PrimeiroNumero - SegundoNumero;
        }
        public double Multiplicar()
        {
            return PrimeiroNumero * SegundoNumero;
        }
        public double Dividir()
        {
            return PrimeiroNumero / SegundoNumero;
        }
    }
}
