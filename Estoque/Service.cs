using System.Globalization;
namespace curso
{
    class produto
    {
        public string Nome;
        public double preco;
        public int quantidade;
        public int num;

        public double TotalEstoque()
        {
            return preco * quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", "+ preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                +quantidade
                +" unidades, Total: "
                +TotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
        public void AdicionarProduto()
        {
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            num = int.Parse(Console.ReadLine());
            quantidade += num;
        }
        public void RemoverProduto()
        {
            Console.WriteLine("Digite o número de produtos que foram removidos do estoque: ");
            num = int.Parse(Console.ReadLine());
            quantidade -= num;
        }
       
    }
}