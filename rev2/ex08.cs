using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digitar 4 valores inteiros:");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int d = int.Parse(Console.ReadLine());

		if (a != b && c != d && a != c) {
			if (a > b && a > c && a > d) Console.WriteLine("Maior Valor = {0}", a);
			if (b > a && b > c && b > d) Console.WriteLine("Maior Valor = {0}", b);
			if (c > a && c > b && c > d) Console.WriteLine("Maior Valor = {0}", c);
			if (d > a && d > b && d > c) Console.WriteLine("Maior Valor = {0}", d);
			
			if (a < b && a < c && a < d) Console.WriteLine("Menor Valor = {0}", a);
			if (b < a && b < c && b < d) Console.WriteLine("Menor Valor = {0}", b);
			if (c < a && c < b && c < d) Console.WriteLine("Menor Valor = {0}", c);
			if (d < a && d < b && d < c) Console.WriteLine("Menor Valor = {0}", d);
		}
		int s1 = 0;
		int s2 = 0;

		if (a > b && b > c && c < d) s1 += a;
		if (b > c && c > d && d < a) s1 += b;
		if (c > d && d > a && a < b) s1 += c;
		if (d > a && a > b && b < c) s1 += d;

		Console.WriteLine(s1);
	
	}
}
