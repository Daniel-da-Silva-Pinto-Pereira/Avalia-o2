using System;
using System.Collections.Generic;

class Venda{
  //Atributos
  protected string formaPagamento;

  //Metodos
  public void credito(){
    if (formaPagamento == "credito"){
      Carrinho.setTotalCompra(total);
      
    }
  }
  public void debito(){
    if (formaPagamento == "debito"){
      valorCompra = 0.9;
      
    }
  }
  public void finalizarCompra(){
    Console.WriteLine ("Sua Compra deu um Total de: {0}, Você gostaria de finalizar sua compra?", totalCompra);
    Console.ReadLine();
  }
}