using CursoPOO.Pagamento;

namespace CursoPOO;
internal class SelecionarPagamento
{
    public static IPagamento Informar() 
    {
        Console.WriteLine("Informe a forma de pagamento (BOLETO ou CARTAO)");

        string opcao = Console.ReadLine();

        switch (opcao )
        {
            case "BOLETO":
                return new Pagamento.Impl.PagamentoBoleto();
            case "CARTAO":
                return new Pagamento.Impl.PagamentoCartaoCredito();
            default:
                return new Pagamento.Impl.PagamentoNaoRealizado();
        }
    }
}
