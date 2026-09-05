Estoque estoque = new Estoque();
Estoque estoque1 = new Estoque();

Produto produto1 = new Produto(1,"Compressor 1/4 Electrolux 220V", 333.99m, 20, "Peças");
Produto produto2 = new Produto(1,"Compressor 1/5 Electrolux 220V", 319.99m, 20, "Peças");
Produto produto3 = new Produto(2,"Compressor 1/3 Electrolux 220V", 540.99m, 20, "Peças");

System.Console.WriteLine(produto1);

System.Console.WriteLine(produto1.RemoverQuantidade(-1));

System.Console.WriteLine(produto1);

System.Console.WriteLine(produto1.RemoverQuantidade(10));

System.Console.WriteLine(produto1);

System.Console.WriteLine(produto1.AdicionarQuantidade(-89));

System.Console.WriteLine("-----------------------------------");

Console.WriteLine(estoque.CadastrarProduto(produto1));
Console.WriteLine(estoque.CadastrarProduto(produto2));
Console.WriteLine(estoque.CadastrarProduto(produto3));

estoque.ListarProdutos();
System.Console.WriteLine("---------------------------------------");
estoque1.ListarProdutos();

