namespace CursoPOO.Frete.Impl;

public class CalcularFreteCorreiosPAC : CalcularFreteCorreios
{
    public override string Nome()
    {
        return "Correios PAC";
    }

    public override int Prazo()
    {
        return 10;
    }

    public override decimal Valor()
    {
        return 15.00m;
    }

    //public override OpcaoFrete Calcular(Cesta cesta)
    //{
    //    return base.Calcular(cesta);
    //}
}
