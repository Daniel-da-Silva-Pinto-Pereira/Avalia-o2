using System;
using System.Collections.Generic;

public abstract class Usuario : IAutenticar{

  //Atributos:

  private string login;
  private string senha;

  public string Logins{
    get{return login;}
    set{
      login = value;
    }
  }
  public string Login{
    get{return login;}
    set{
      login = value;
    }
  }
  public string Senhas{
    get{return senha;}
    set{
      senha = value;
    }
  }
  public string Senha{
    get{return senha;}
    set{
      senha = value;
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

  public virtual void Privilegios(){
    
  }

  //Construtor:
  public Usuario(string s, string l, string m, int c_p_f, int i, string n, int tel, bool st, string tp){
    senha = s;
    login = l;
    matricula = m;
    cpf = c_p_f;
    id = i;
    nome = n;
    telefone = tel;
    status = st;
    tipo = tp;
  }

}