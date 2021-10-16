using System;
using System.Collections.Generic;

class Venda{
  //Atributos
  protected string formaPagamento;
  

  //Metodos
  public void credito(){
    if (formaPagamento == "credito"){
      setTotalCompra(value*1.1);
    }
      
      
    
  }
  
  public void finalizarCompra(){
    Console.WriteLine ("Sua Compra deu um Total de: {0}, Você gostaria de finalizar sua compra?", Carrinho.getTotalCompra());
    Console.ReadLine();
  }

}