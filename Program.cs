
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;

bool sair = false;
Estoque estoque = new Estoque();


while(!sair)

{
   
    ExibirMenu();
    System.Console.Write("Digite a opção: ");
    string opcao = Console.ReadLine() ?? string.Empty;

    switch(opcao)
    {
        case "1":
            System.Console.Write("Id: ");
            bool conversaoIdPrincipal = int.TryParse(Console.ReadLine(), out int idPrincipal);

            if(!conversaoIdPrincipal)
            {
                System.Console.WriteLine("Dado inserido no ID e inválido!");
                break;
            }

            if(idPrincipal <= 0)
            {
                System.Console.WriteLine("Id não pode ser menor ou igual a zero!");
                break;
            }
          
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? string.Empty;

            if(string.IsNullOrWhiteSpace(nome))
            {
                System.Console.WriteLine("O nome do produto não pode ficar vazio!");
                break;
            }

            nome = nome.Trim();

            System.Console.Write("Preço: ");
            bool conversaoPreco = decimal.TryParse(Console.ReadLine(), out decimal preco);

            if(!conversaoPreco)
            {
                System.Console.WriteLine("Dado inserido no preço e inválido!");
                break;
            }

            if(preco <= 0)
            {
                System.Console.WriteLine("O preço do produto não poder ser menor ou igual a zero!");
                break;
            }

            System.Console.Write("Quantidade: ");
            bool conversaoQtd = int.TryParse(Console.ReadLine(), out int qtd);

            if(!conversaoQtd)
            {
                System.Console.WriteLine("Dado inserido na quantidade e inválido");
                break;
            }

            if(qtd < 0)
            {
                System.Console.WriteLine("A quantidade não pode ser menor ou igual a 0");
                break;
            }

            System.Console.Write("Categoria: ");
            string categoria = Console.ReadLine() ?? string.Empty;

            if(string.IsNullOrWhiteSpace(categoria))
            {
                System.Console.WriteLine("A categoria do produto não pode ficar vazio!");
                break;
            }

            categoria = categoria.Trim();

            Produto produto = new Produto(idPrincipal, nome, preco, qtd, categoria);

            Console.WriteLine(estoque.CadastrarProduto(produto));
            break;
        case "2":
            estoque.ListarProdutos();
            break;
        case "3":
            System.Console.Write("Digite o id do produto que você deseja procurar: ");
            bool conversaoId = int.TryParse(Console.ReadLine(), out int id1);

            if(!conversaoId)
            {
                System.Console.WriteLine("ID inválido. Digite um número inteiro");
                break;
            }

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
            bool conversaoId2 = int.TryParse(Console.ReadLine(), out int id2);

            if(!conversaoId2)
            {
                System.Console.WriteLine("ID inválido. Digite um número inteiro");
                break;
            }

            estoque.RemoverProdutoPorId(id2);
            break;
        case "5":
            estoque.ListarProdutos();
            System.Console.WriteLine("------------------------------------------------------------------------------------");

            System.Console.Write("Digite o id do produto que você deseja aumentar a quantidade(Id): ");
            bool entradaId = int.TryParse(Console.ReadLine(), out int saidaId);

            if(!entradaId)
            {
                System.Console.WriteLine("Dado inserido no id é inválido!");
                break;
            }

            if(saidaId <= 0)
            {
                System.Console.WriteLine("O Id não pode ser menor ou igual a zero");
                break;
            }

            Produto? produtoBuscado = estoque.BuscarProdutoPorId(saidaId);

            if(produtoBuscado != null)
            {
                System.Console.Write("Digite a quantidade que deseja adicionar no produto: ");
                bool conversaoQtd2 = int.TryParse(Console.ReadLine(), out int qtd2);

                if(!conversaoQtd2)
                {
                    System.Console.WriteLine("Dado inválido inserido na quantidade a ser adicionada!");
                    break;
                }

                if(qtd2 <= 0)
                {
                    System.Console.WriteLine("A quantidade não pode ser menor ou igual a zero!");
                    break;
                }

                Console.WriteLine(produtoBuscado.AdicionarQuantidade(qtd2));
                break;
            }
           
            System.Console.WriteLine("Produto não encontrado!");
            break;
        case "6":
            estoque.ListarProdutos();
            System.Console.WriteLine("------------------------------------------------------------------------------------");

            System.Console.Write("Digite o id do produto que você deseja remover determinada quantidade(Id): ");
            bool entradaIdRemocao = int.TryParse(Console.ReadLine(), out int saidaIdRemocao);

            if(!entradaIdRemocao)
            {
                System.Console.WriteLine("Dado inserido no id é inválido!");
                break;
            }

            if(saidaIdRemocao <= 0)
            {
                System.Console.WriteLine("O Id não pode ser menor ou igual a zero");
                break;
            }

            Produto? produtoBuscado1 = estoque.BuscarProdutoPorId(saidaIdRemocao);

            if(produtoBuscado1 != null)
            {
                System.Console.Write("Digite a quantidade que deseja remover no produto: ");
                bool conversaoQtd2 = int.TryParse(Console.ReadLine(), out int qtd2);

                if(!conversaoQtd2)
                {
                    System.Console.WriteLine("Dado inválido inserido na quantidade a ser removida!");
                    break;
                }

                if(qtd2 <= 0)
                {
                    System.Console.WriteLine("A quantidade não pode ser menor ou igual a zero!");
                    break;
                }

                Console.WriteLine(produtoBuscado1.RemoverQuantidade(qtd2));
                break;
            }
           
            System.Console.WriteLine("Produto não encontrado!");
            break;
        case "7":
            sair = true;
            break;
        default:
            System.Console.WriteLine("Opção inserida não é aceita!");
            break;

    }
}



void ExibirMenu()
{
    
    System.Console.WriteLine("==============================================================================================");
    System.Console.WriteLine("--------------------------------Gerenciamento de Estoque--------------------------------------");
    System.Console.WriteLine("==============================================================================================");

    System.Console.WriteLine("1 - Cadastrar");
    System.Console.WriteLine("2 - Listar");
    System.Console.WriteLine("3 - Buscar");
    System.Console.WriteLine("4 - Remover");
    System.Console.WriteLine("5 - Adicionar quantidade");
    System.Console.WriteLine("6 - Remover quantidade");
    System.Console.WriteLine("7 - Sair");
    System.Console.WriteLine("------------------------------------------------------------------------------------------");

}

