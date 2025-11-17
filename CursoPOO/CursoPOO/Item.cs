using System.Security.AccessControl;

namespace CursoPOO
{
    public class Item
    {
        //CONSTANTES 
        private const int PadraoQuantidade = 1;
        //CONSTANTES
        public string Nome { get; set; }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
            }
        }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
            }
        }

        public Item()
        {
            _quantidade = PadraoQuantidade;
            _preco = 0m;
        }

        public Item(string nome, decimal preco) 
        {
            Nome = nome;
            _quantidade = PadraoQuantidade;
            _preco = preco;
        }


        //ESTATICOS
        public static Item CriarBola()
        {
            var bola = new Item();
            bola.Nome = "Bola de Futebol";
            bola.Quantidade = 1;
            bola.Preco = 99M;

            return bola;
        }
        //ESTATICOS
    }
}

//--------------------------------------------------------------------------------------------------

//USANDO REFERENCIA NULA//

//public void Teste(string p1, int p2)
//{
//    /// codigo
//}

//public string Teste2()
//{
//    return Nome;
//}

//--------------------------------------------------------------------------------------------------

//JEITO 2 DE FAZER (C#)//

//private string _nome;
//private int _quantidade;
//private decimal _preco;

//public string Nome
//{
//    get { return _nome; }
//    set {
//        if (String.IsNullOrEmpty(_nome))
//        {
//            throw new ArgumentException("Nome está vazio.");
//        }
//        _nome = value; 
//    }
//}

//public int Quantidade { get; set; }

//--------------------------------------------------------------------------------------------------

//--JEITO 1 DE FAZER (JAVA)--//

//public string getNome()
//{
//    return _nome;
//}

//public void setNome(string nome)
//{   
//    if (string.IsNullOrEmpty(nome))
//    {
//        throw new ArgumentException("Nome está vazio.");
//    }
//    this._nome = nome;
//}

//--------------------------------------------------------------------------------------------------
