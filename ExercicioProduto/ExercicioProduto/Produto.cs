using System.Globalization;
namespace ExercicioProduto
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Estoque { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Estoque = quantidade;
        }

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Estoque = 0;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return Preco;
        }



        public int GetQuantidade()
        {
            return Estoque;
        }


        public double ValorTotalEmEstoque()
        {
            return Estoque * Preco;

        }

        public void AdicionarProduto(int quantity)
        {
            Estoque += quantity;
        }

        public void RemoverProduto(int quantity)
        {
            Estoque -= quantity;
        }

        public override string ToString()
        {
            return _nome + ", " + Estoque + " unidades em estoque, Total R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
