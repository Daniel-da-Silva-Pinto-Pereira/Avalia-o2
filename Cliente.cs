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

  public Cliente(string s, string l, string m, string c_p_f, string i, string n, string tel, bool st, string tp):base(s,l,m,c_p_f,i,n,tel,st,tp){}

  //Login de um cliente normal
  public override bool validarUsuario(string c, string s){
    if (cpf == "92220417042" && Senha == "person123");
      return true;
    }

  //Privilégios
  public override string Privilegios(){
    string privC = "Consulta de produtos disponível para compra; comprar produtos";
    return privC;
  }

}