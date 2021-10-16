using System;
using System.Collections.Generic;

class Atendente_virtual : Usuario{
  //Atributos
  protected string cargo;

  //Metodos

  public Atendente_virtual(string s, string l, string m, int c_p_f, int i, string n, int tel, bool st, string tp):base(s,l,m,c_p_f,i,n,tel,st,tp){
      
  }

  // Login funcionário
  public override bool validarUsuario(string m, string s){
    if (matricula == "func" && Senha == "func123");
      return true;
  }

  //Privilégios
  public override string Privilegios(){
    string privF = "consulta de estoque, produtos e pedidos; auxílio aos clientes em dúvidas e sugestões";
    return privF;
  }

  

}