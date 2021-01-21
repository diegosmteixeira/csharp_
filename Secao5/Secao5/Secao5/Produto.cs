using System.Globalization;

namespace Secao5
{
    class Produto
    {
        //Nao é possivel criar uma Auto Propertie para o nome, pois ele pede uma condição especial.
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome; Preco = preco; Quantidade = quantidade;
        }

        public Produto (string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set 
            { 
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total : $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
