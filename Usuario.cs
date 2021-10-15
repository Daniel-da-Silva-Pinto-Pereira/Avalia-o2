using System;
using System.Collection.Generic;

abstract class Usuario : IAutenticar{

  //Atributos:

  protected string login;
  protected string senha;
  public string Login{
    get{
      return login;
    }
    set{
      login = string l;
    }
  }

  public string Senha{
    get{
      return senha;
    }
    set{
      senha = string s;
    }
  }

  protected string matricula;
  protected int cpf;
  protected int id;
  protected string nome;
  protected int telefone;
  protected bool status;
  protected string tipo;

  //Metodos:

  //Login de um cliente normal
  public void validarUsuario(int c, string s){
  }

  // Login funcionário
  public void validarUsuario(string m, string s){
  }

  // Login admin
  public void validarUsuario(string m, string s, int mandante){
  }

  //Construtor:
  public Usuario(string l, string s, string m, int c_p_f, int i, string n, int tel, bool st, string tp){
    login = l;
    senha = s;
    matricula = m;
    cpf = c_p_f;
    id = id;
    nome = n;
    telefone = tel;
    status = st;
    tipo = tp;
  }

}