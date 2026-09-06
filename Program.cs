
using System.Linq.Expressions;
using System.Runtime.Serialization;

bool sair = false;
Estoque estoque = new Estoque();

System.Console.WriteLine("==============================================================================================");
System.Console.WriteLine("--------------------------------Gerenciamento de Estoque--------------------------------------");
System.Console.WriteLine("==============================================================================================");


while(!sair)
{
    System.Console.WriteLine("1 - Cadastrar");
    System.Console.WriteLine("2 - Listar");
    System.Console.WriteLine("3 - Buscar");
    System.Console.WriteLine("4 - Remover");
    System.Console.WriteLine("5 - Sair");
    System.Console.WriteLine("------------------------------------------------------------------------------------------");

    System.Console.Write("Digite a opção: ");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            System.Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();

            System.Console.Write("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            System.Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            System.Console.Write("Categoria: ");
            string categoria = Console.ReadLine();

            Produto produto = new Produto(id, nome, preco, qtd, categoria);

            estoque.CadastrarProduto(produto);
            break;
        case "2":
            estoque.ListarProdutos();
            break;
        case "3":
            System.Console.Write("Digite o id do produto que você deseja procurar: ");
            int id1 = int.Parse(Console.ReadLine());

            Produto? produto2 = estoque.BuscarProdutoPorId(id1);

            if(produto2 != null)
            {
                System.Console.WriteLine("Produto encontrado!");
            }
            else
            {
                System.Console.WriteLine("Produto não encontrado!");
            }


            break;
        case "4": 

            System.Console.Write("Digite o id do produto que você deseja remover: ");
            int id2 = int.Parse(Console.ReadLine());

            estoque.RemoverProdutoPorId(id2);
            break;
        case "5":
            sair = true;
            break;
        default:
            System.Console.WriteLine("Opção inserida não é aceita!");
            break;

    }


}