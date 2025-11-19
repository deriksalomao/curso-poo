namespace CursoPOO.Frete.Impl;

public class CalcularFreteCorreiosSedex : CalcularFreteCorreios
{
    public override string Nome()
    {
        return "Correios Sedex";
    }

    public override int Prazo()
    {
        return 5;
    }

    public override decimal Valor()
    {
        return 25.00m;
    }
}
