using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo da área e perímetro de um círculo");
        Console.WriteLine("Digite o valor do raio:");
        double r = Convert.ToDouble(Console.ReadLine());

       
        double a = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"Área do círculo: {a:F2}");

      
        double peri = 2 * Math.PI * r;
        Console.WriteLine($"Perímetro do círculo: {peri:F2}");
    }
}