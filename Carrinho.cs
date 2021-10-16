using System;
using System.Collections.Generic;

public class Carrinho{
  //Atributos
  protected List<double> listaCarrinho = new List<double>();
  protected double totalCompra;

  public  double getTotalCompra(){
    return totalCompra;
  }

   public  void setTotalCompra(double total){
    totalCompra = total;
  }

  //Metodos
  public void excluirProdCarrinho(){

  }
  public void comprarProduto(){

  }
  public void visualizarTotalCompra(){

  }
  public void fecharCompra(){

  }

  public Carrinho(List<double> l, double t){
    listaCarrinho = l;
    totalCompra = t;
  }
  
}