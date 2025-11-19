namespace CursoPOO.Pagamento.Impl;

internal class PagamentoBoleto : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine($"Gerando o boleto da cesta no valor de: {cesta.ValorTotalFormatado}");
        Console.WriteLine("Boleto gerado com sucesso.");
    }
}
