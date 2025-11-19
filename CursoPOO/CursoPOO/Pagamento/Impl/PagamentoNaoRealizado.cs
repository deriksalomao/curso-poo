namespace CursoPOO.Pagamento.Impl;
internal class PagamentoNaoRealizado : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine("O pagamento não foi realizado.");
    }
}
