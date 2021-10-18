using System;
using System.Collections.Generic;

class Atendente_virtual : Usuario{
  //Atributos
  protected string cargo;

  //Métodos:

  public Atendente_virtual(string s, string l, string m, string c_p_f, string i, string n, string tel, bool st, string tp):base(s,l,m,c_p_f,i,n,tel,st,tp){
      
  }

  //Privilégios
  public override string Privilegios(){
    string privF = "consulta de estoque, produtos e pedidos; auxílio aos clientes em dúvidas e sugestões";
    return privF;
  }

  

}