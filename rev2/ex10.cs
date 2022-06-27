using System;
class Program {
  public static void Main (){
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string data= Console.ReadLine();
    string[] valores= data.Split("/");
    int dia = int.Parse(valores[0]);
    int mes = int.Parse(valores[1]);
    int ano = int.Parse(valores[2]);
    
if ((ano >= 1900) && (ano <= 2100)){
  if ((mes >= 1) && (mes <= 12)){
    if ((dia >= 1) && (dia >= 31)){
      Console.WriteLine("Data válida:)");
    }
    else {
      Console.WriteLine("Data inválida");
    }
  }
  else {
      Console.WriteLine("Data inválida");
  }
}
else {
      Console.WriteLine("Data inválida");
  }
    
  }
}
