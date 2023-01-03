using curso;

namespace Nelio
{  
    class program{
        static void Main(String[] args)
        {
            produto p = new produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: "+ p);
            p.AdicionarProduto();
            Console.WriteLine("Dados do produto: "+ p);
            p.RemoverProduto();
            Console.WriteLine("Dados do produto: "+ p);
        }
    }
}