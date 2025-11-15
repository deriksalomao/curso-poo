using System.Security.AccessControl;

namespace CursoPOO
{
    public class CarrinhoItem
    {
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

        public CarrinhoItem()
        {
            _quantidade = 1;
            _preco = 0m;
        }

        public CarrinhoItem(string nome, decimal preco) 
        {
            Nome = nome;
            _quantidade = 1;
            _preco = preco;
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
    }
}
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
