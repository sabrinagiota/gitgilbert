using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Valores para organizar:");
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());

		int menor = 0;
		int medio = 0;
		int maior = 0;

		if ((n1 > n2) && (n1 > n3)) {maior = n1;}
		else if ((n2 > n1) && (n2 > n3)) {maior = n2;}
		else if ((n3 > n1) && (n3 > n2)) {maior = n3;}

		if ((n1 > n2) && (n1 < n3)) {medio = n1;}
		else if ((n2 > n1) && (n2 < n3)) {medio = n2;}
		else if ((n3 > n1) && (n3 < n2)) {medio = n3;}
		
		if ((n1 > n3) && (n1 < n2)) {medio = n1;}
		else if ((n2 > n3) && (n2 < n1)) {medio = n2;}
		else if ((n3 > n2) && (n3 < n1)) {medio = n3;}

		if ((n1 < n2) && (n1 < n3)) {menor = n1;}
		else if ((n2 < n1) && (n2 < n3)) {menor = n2;}
		else if ((n3 < n1) && (n3 < n2)) {menor = n3;}

		Console.WriteLine("Em ordem crescente: {0}, {1}, {2}", menor, medio, maior);


	}
}
