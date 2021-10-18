using System;
using System.Collections.Generic;

public class Carrinho{
  //Atributos
  protected List<string> listaCarrinho = new List<string>();
  protected double totalCompra;
  protected bool fechar;

  //Métodos:

  public  void setTotalCompra(double total){
    totalCompra = total;
  }
  public void excluirProdCarrinho(string nome){
    listaCarrinho.Remove(nome);
  }
  public void addProdCar(string prod){
    listaCarrinho.Add(prod);
  }
  public double visualizarTotalCompra(){
    return totalCompra;

  }
  public bool fecharCompra(bool f){
    fechar = f; 
    return fechar;
  }

  public Carrinho(List<string> l, double t, bool f){
    listaCarrinho = l;
    totalCompra = t;
    fechar = f;
  }
  
}