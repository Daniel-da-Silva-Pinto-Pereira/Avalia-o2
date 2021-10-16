using System;
using System.Collections.Generic;

class Cliente : Usuario{
  //Atributos
  protected string dtCadastro;

  //Metodos
  public string Logins{
      get{
        return Login;
      }
      set{
        Login = value;
      }
    }
    
  public void adicionarProdutoCarrinho(){
    
  }

  public override void Privilegios(){
      Console.WriteLine("");
  }

  public Cliente(string s, string l, string m, int c_p_f, int i, string n, int tel, bool st, string tp):base(s,l,m,c_p_f,i,n,tel,st,tp){
    
  }

  


}