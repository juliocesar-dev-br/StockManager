bool sair = false;
Estoque estoque = new Estoque();


while(!sair)
{
   
    ExibirMenu();
    Console.Write("Digite a opção: ");
    string opcao = Console.ReadLine() ?? string.Empty;

    switch(opcao)
    {
        case "1":
            int idPrincipal = LerInteiroPositivo("Id: ");
            string nome = LerTextoObrigatorio("Nome: ");
            decimal preco = LerDecimalPositivo("Preço: ");
            int qtd = LerInteiroNaoNegativo("Quantidade: ");
            string categoria = LerTextoObrigatorio("Categoria: ");

            Produto produto = new Produto(idPrincipal, nome, preco, qtd, categoria);

            Console.WriteLine(estoque.CadastrarProduto(produto));
            break;
        case "2":
            estoque.ListarProdutos();
            break;
        case "3":
            int id1 = LerInteiroPositivo("Digite o ID do produto: ");

            Produto? produto2 = estoque.BuscarProdutoPorId(id1);

            if(produto2 != null)
            {
                Console.WriteLine("Produto encontrado!");
                Console.WriteLine(produto2);
                break;
            }
          
            Console.WriteLine("Produto não encontrado!");
            break;
        case "4": 
            Console.WriteLine("------------------------------------------------------------------------------------");
            int id2 = LerInteiroPositivo("Digite o id do produto que você deseja remover: ");

            estoque.RemoverProdutoPorId(id2);
            break;
        case "5":
            estoque.ListarProdutos();
            Console.WriteLine("------------------------------------------------------------------------------------");
          
            int saidaId = LerInteiroPositivo("Digite o id do produto que você deseja aumentar a quantidade(Id): ");

            Produto? produtoBuscado = estoque.BuscarProdutoPorId(saidaId);

            if(produtoBuscado != null)
            { 
                int qtd2 = LerInteiroPositivo("Digite a quantidade que deseja adicionar no produto: ");

                Console.WriteLine(produtoBuscado.AdicionarQuantidade(qtd2));
                break;
            }
           
            Console.WriteLine("Produto não encontrado!");
            break;
        case "6":
            estoque.ListarProdutos();
            Console.WriteLine("------------------------------------------------------------------------------------");

            int saidaIdRemocao = LerInteiroPositivo("Digite o id do produto que você deseja remover determinada quantidade(Id): ");
            Produto? produtoBuscado1 = estoque.BuscarProdutoPorId(saidaIdRemocao);

            if(produtoBuscado1 != null)
            {
                Console.WriteLine("------------------------------------------------------------------------------------");
                int qtd2 = LerInteiroPositivo("Digite a quantidade que deseja remover no produto: ");

                Console.WriteLine(produtoBuscado1.RemoverQuantidade(qtd2));
                break;
            }
           
            Console.WriteLine("Produto não encontrado!");
            break;
        case "7":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inserida não é aceita!");
            break;

    }
}


decimal LerDecimalPositivo(string mensagem)
{
    while(true)
    {
        Console.Write(mensagem);

        if(decimal.TryParse(Console.ReadLine(), out decimal resultado) && resultado > 0)
        {
            return resultado;
        }

        Console.WriteLine("Digite um número decimal maior que zero.");
    }
}

int LerInteiroPositivo(string mensagem)
{
    while(true)
    {
        Console.Write(mensagem);

        if(int.TryParse(Console.ReadLine(), out int resultado) && resultado > 0)
        {
            return resultado;
        }

        Console.WriteLine("Digite um número inteiro maior que zero.");

    }
}


int LerInteiroNaoNegativo(string mensagem)
{
    while(true)
    {
        Console.Write(mensagem);

        if(int.TryParse(Console.ReadLine(), out int resultado) && resultado >= 0)
        {
            return resultado;
        }

        Console.WriteLine("Digite um número inteiro maior ou igual a zero.");
    }
}



string LerTextoObrigatorio(string mensagem)
{
    while(true)
    {
        Console.Write(mensagem);

        string opcaoEscolhida = Console.ReadLine() ?? string.Empty;

        if(!string.IsNullOrWhiteSpace(opcaoEscolhida))
        {
            opcaoEscolhida = opcaoEscolhida.Trim();
            return opcaoEscolhida;
        }
      
        Console.WriteLine("Digite uma string válida...");

    }
}


void ExibirMenu()
{
    
    Console.WriteLine("==============================================================================================");
    Console.WriteLine("--------------------------------Gerenciamento de Estoque--------------------------------------");
    Console.WriteLine("==============================================================================================");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Buscar");
    Console.WriteLine("4 - Remover");
    Console.WriteLine("5 - Adicionar quantidade");
    Console.WriteLine("6 - Remover quantidade");
    Console.WriteLine("7 - Sair");
    Console.WriteLine("------------------------------------------------------------------------------------------");

}

