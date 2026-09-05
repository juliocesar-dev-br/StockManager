Produto produto1 = new Produto(001,"Compressor 1/4 Electrolux 220V", 333.99m, 20, "Peças");

System.Console.WriteLine(produto1);

System.Console.WriteLine(produto1.RemoverQuantidade(-1));

System.Console.WriteLine(produto1);

System.Console.WriteLine(produto1.RemoverQuantidade(10));

System.Console.WriteLine(produto1);

System.Console.WriteLine(produto1.AdicionarQuantidade(-89));