using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("C�lculo da �rea e per�metro de um c�rculo");
        Console.WriteLine("Digite o valor do raio:");
        double r = Convert.ToDouble(Console.ReadLine());

       
        double a = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"�rea do c�rculo: {a:F2}");

      
        double peri = 2 * Math.PI * r;
        Console.WriteLine($"Per�metro do c�rculo: {peri:F2}");
    }
}