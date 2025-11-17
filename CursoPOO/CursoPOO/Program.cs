using CursoPOO;

//--------------------------------------------------------------------------------------------------

//TESTES//

//CarrinhoItem bola = new CarrinhoItem();
//bola.nome = "Bola de Futebol";
//bola.quantidade = 1;
//bola.preco = 99.90M;

//CarrinhoItem camisa = new CarrinhoItem();
//camisa.nome = "Camisa do Brasil";
//camisa.quantidade = 1;
//camisa.preco = 149.99M;

//CarrinhoItem bola = new CarrinhoItem();

//bola.Nome = "Bola de futebol";
//bola.Quantidade = 0;
//bola.Teste("Teste", 1);
//Item bola = Item.CriarBola();

//Console.WriteLine("bola");

//--------------------------------------------------------------------------------------------------


Cesta cesta = new Cesta();

Item bola = new Item("Bola de futebol", 99.90M);
cesta.Itens.Add(bola);

Item camiseta = new Item("Camiseta do Corinthians", 149.99M);
cesta.Itens.Add(camiseta);

foreach (var item in cesta.Itens)
{
    Console.WriteLine($"Item: {item.Nome} - Quantidade: {item.Quantidade} - Preço: {item.Preco}");
}

Console.ReadLine();