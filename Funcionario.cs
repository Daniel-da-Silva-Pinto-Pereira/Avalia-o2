using System;
using System.Collections.Generic;

abstract class Funcionario : Usuario{
//Atributos
protected string cargo;

//Metodos

public override void Privilegios(){
    Console.WriteLine("");
}

public Funcionario(string s, string l, string m, int c_p_f, int i, string n, int tel, bool st, string tp):base(s,l,m,c_p_f,i,n,tel,st,tp){
    
  }

}