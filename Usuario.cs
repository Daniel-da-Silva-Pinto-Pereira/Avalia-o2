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
  protected string cpf;
  protected string id;
  protected string nome;
  protected string telefone;
  protected bool status;
  protected string tipo;

  //Metodos:

  //Sobrecarga e Sobrescrita:
  //Login de um cliente normal
  public virtual bool validarUsuario(string c, string s){
    return false;
  }
  
  // Login admin
  public virtual bool validarUsuario(string m, string s, int mand){
    return false;
  }

  // Sobrescrita:
  public virtual string Privilegios(){
    string priv = "Privilégio genérico";
    return priv;
  }

  //Construtor:
  public Usuario(string s, string l, string m, string c_p_f, string i, string n, string tel, bool st, string tp){
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