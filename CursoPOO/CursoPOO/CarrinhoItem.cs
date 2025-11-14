namespace CursoPOO
{
    public class CarrinhoItem
    {

        private string _nome;
        private int _quantidade;
        private decimal _preco;

        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {   
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Nome está vazio.");
            }
            this._nome = nome;
        }

    }
}
