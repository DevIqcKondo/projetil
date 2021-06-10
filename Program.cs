using System;

namespace projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.80665;
            double anguloEmGraus;
            double v;
            double anguloRadianos;
            double alcance;
            double alt;

            
             Console.BackgroundColor=ConsoleColor.Blue;
             Console.ForegroundColor=ConsoleColor.Black;
             Console.WriteLine("--------");
             Console.WriteLine("Projetil");
             Console.WriteLine("--------");
             Console.ResetColor();
             Console.Write("Informe a velocidade em m/s: ");
             v = Convert.ToDouble(Console.ReadLine());

             Console.Write("Informe o angulo em graus: ");
             anguloEmGraus = Convert.ToDouble(Console.ReadLine());
          
             anguloRadianos = anguloEmGraus * (Math.PI/180);

            
             alcance = (Math.Pow(v, 2) * Math.Sin(2 * anguloRadianos)) / g;
             Console.WriteLine($"Alcance: {alcance:N2}m");
            
             alt = Math.Pow((v * Math.Sin(anguloRadianos)), 2) / (2 * g);
             Console.WriteLine($"Altura máxima: {alt:N2}m");

        }
    }
}
