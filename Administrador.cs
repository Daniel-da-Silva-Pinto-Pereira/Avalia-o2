using System;
using System.Collections.Generic;

class Administrador : Usuario{
  //Atributos
  //protected string cadastrarProd;
  protected int qtdProduto = 100;
  protected List<string> listaProdutos = new List<string>();

  //Metodos
  public void cadastrarFunc(){

  }

  public void adicionarProduto(){
    for(int 1 != 0; i<=qtdProduto; i++){
    }

  }
  public void excluirProduto(){

  }
  public void aprovarPedido(){

  }
  public void alterarStatusCompra(){

  }
  public void alterarEstoque(){

  }
  public void consultarCompras(){
    
  }

  public override void Privilegios(){
      Console.WriteLine("");
  }

  public Administrador(string s, string l, string m, int c_p_f, int i, string n, int tel, bool st, string tp):base(s,l,m,c_p_f,i,n,tel,st,tp){
    
  }

  
}