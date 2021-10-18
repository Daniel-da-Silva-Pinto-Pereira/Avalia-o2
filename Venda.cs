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
    }else if(formaPagamento == "debito"){
      totalCompra += 0.6;
    }else{
      Console.WriteLine("Forma de pagamento não identificada. Repita o processo!");
    }return totalCompra;
  }
  
  public string finalizarCompra(){
    Console.WriteLine("Sua compra deu um total de R${0}, você gostaria de finalizá-la?", visualizarTotalCompra());
    string sn = Console.ReadLine();
    if (sn == "sim"){
      Console.WriteLine("Volte sempre!");
    }else{
      Console.WriteLine("Procura por mais roupas, você pode gostar de outras. Obrigado pela visita de qualquer forma!");}
    return sn;
  }
}