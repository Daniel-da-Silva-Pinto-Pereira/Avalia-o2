using System;
using System.Collections.Generic;

class Program {
  public static void Main(){
    Console.WriteLine("CENTRO&LESTE");
    Console.WriteLine("------------------------------------------");

    // Instanciando um usuário administrador
    Administrador admCarlos = new Administrador("123", "admCarlos", "2021abc", "12345678910", "002021203", "Carlos", "2733334125", true, "Administrador", 500);

    //Coletando produtos para uma variável do tipo List<string>
    List<string> prod1 = new List<string>(new string[]
      {
        "1",
        "Blusa",
        "Feminina", 
        "50.00"
      });

    //Adicionando produto a lista de produto através do método addProduto
    admCarlos.addProduto(prod1);

    //Exibindo os produtos no estoque
    Console.WriteLine("Produto "+prod1[0]+":");

    Console.WriteLine("------------------------------------------");
    
    admCarlos.consultarEstoque().ForEach(Console.WriteLine);

    Console.WriteLine("------------------------------------------");

    //Variável para receber se a compra foi fechada ou não
    bool t = true;

    //Convertendo valor do produto string em double
    double totalC = Convert.ToDouble(prod1[3]);
    //Instanciando meuCarrinho com os parâmetros necessários
    Carrinho meuCarrinho = new Carrinho(prod1, totalC, t);

    //Visualizando total do produto/compra
    Console.WriteLine("Total do produto é "+meuCarrinho.visualizarTotalCompra());

    Console.WriteLine("------------------------------------------");

    //Instanciando a venda com os parâmetros
    Venda minhaVenda = new Venda(prod1, totalC, 23, t);
    string opcao = "credito";
    Console.WriteLine("Com a opção "+opcao+ "a venda total ficou no valor de "+minhaVenda.metodoPag(opcao));
    //Finalização da compra
    Console.WriteLine(minhaVenda.finalizarCompra());

    Console.WriteLine("------------------------------------------");
    //Instanciando atendente
    Atendente_virtual Daniel = new Atendente_virtual("1234", "atDaniel", "152345", "16695532211", "1526", "Daniel da Silva", "2799658563", true, "Atendente");

    //Instanciando cliente
    Cliente Carol = new Cliente("1475", "CarolOliveira", "202111365", "18896523141", "258", "Carol Oliveira", "27999975685", true, "Cliente");

    //Privilégio
    Console.WriteLine(Daniel.getNome()+" tem as permissões: "+Daniel.Privilegios());
    Console.WriteLine("------------------------------------------");

    Console.WriteLine(admCarlos.getNome()+" tem as permissões: "+admCarlos.Privilegios());
    Console.WriteLine("------------------------------------------");

    Console.WriteLine(Carol.getNome()+" tem as permissões: "+Carol.Privilegios());



  }
} 