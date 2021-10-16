using System;
using System.Collections.Generic;

class Administrador : Usuario{
  //Atributos 
  //protected string cadastrarProd;
  protected int qtdProduto = 100;
  protected List<string> listaProdutos = new List<string>(); // colocar na classe Produtos
  protected int mandante = 500;

  //Metodos

  public void addProduto(List<string> prod){
    //for(int i = 1; i<=qtdProduto; i++){
    //  Console.WriteLine("teste");
    //}
    listaProdutos = prod;
  }
  public void excluirProduto(){

  }
  public void consultarProdutos(){
    
  }
  public void consultarPedidos(){
    
  }
  public List<string> consultarEstoque(){
    return listaProdutos;
  }


  public Administrador(string s, string l, string m, int c_p_f, int i,string n, int tel, bool st, string tp, int mand):base(s,l,m,c_p_f,i,n,tel,st,tp){
    mand = mandante;
  }

  // Login admin
  public override bool validarUsuario(string m, string s, int mand){
    if (matricula == "admin" && Senha == "@admin" && mand == 500);
      return true;
  }

  //Privilégios
  public override string Privilegios(){
    string privA = "Cadastro de funcionários; inclusão/exclusão/modificação/consulta de estoque, produtos e pedidos";
    return privA;
  }

  
}