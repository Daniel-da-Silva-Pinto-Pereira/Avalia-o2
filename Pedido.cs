using System;
using System.Collections.Generic;

public class Pedido : Carrinho{
  //Atributos
  protected int numeroPedido;
  //protected double totalCompra;

  //Metodos

  public Pedido(List<double> l, double t):base(l,t){}

  public void listarCompra(){
    
  }
}