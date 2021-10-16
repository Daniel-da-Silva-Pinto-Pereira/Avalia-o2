using System;
using System.Collections.Generic;

public class Venda : Pedido{
  //Atributos
  protected string formaPagamento;

  public Venda(List<double> l, double t, int n):base(l,t){}
  

  //Metodos
  public void credito(){
    if (formaPagamento == "credito"){
      totalCompra = totalCompra * 1.1;
      numeroPedido = 1;
      
    }
      
      
    
  }
  
  public void finalizarCompra(){
    Console.WriteLine ("Sua Compra deu um Total de: {0}, Você gostaria de finalizar sua compra?", getTotalCompra());
    //Console.ReadLine();
  }

}