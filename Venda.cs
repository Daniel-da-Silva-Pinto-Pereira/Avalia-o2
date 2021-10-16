using System;
using System.Collections.Generic;

public class Venda : Pedido{
  //Atributos
  protected string formaPagamento;

  public Venda(List<string> l, double t, int n, bool f):base(l,t,f){}
  

  //Metodos
  public double metodoPag(string nome){
    formaPagamento = nome;
    if (formaPagamento == "credito"){
      totalCompra = totalCompra * 1.1;
      //numeroPedido = 1;
    }else if(formaPagamento == "debito"){
      totalCompra += 0.6;
    }else{
      Console.WriteLine("Forma de pagamento na identificada. Repita o processo!");
    }return totalCompra;
  }
  
  public void finalizarCompra(){
    Console.WriteLine ("Sua Compra deu um Total de: {0}, Você gostaria de finalizar sua compra?", visualizarTotalCompra());
    //Console.ReadLine();
  }
}