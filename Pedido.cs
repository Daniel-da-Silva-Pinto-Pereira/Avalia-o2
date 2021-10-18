using System;
using System.Collections.Generic;

public class Pedido : Carrinho{
  //Atributos
  protected int numeroPedido;

  //Metodos
  public Pedido(List<string> l, double t, bool f):base(l,t,f){}

}