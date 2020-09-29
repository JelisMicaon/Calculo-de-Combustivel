using System;

namespace Royerzinho {
    class Program {
        static double Calculo(int horas, int velocidade) {
            return Math.Round(((Convert.ToDouble(horas) * Convert.ToDouble(velocidade)) / 12), 3);
        }
        static void Main() {
            double consumo;
            try {
                Console.WriteLine("Calcular combustível gasto.");
                Console.WriteLine("(O carro como padrão gasta 12L por KM)");

                do {
                    Console.Write("Quantas horas a viagem ira levar? ");
                    int.TryParse(Console.ReadLine(), out int horas);
                    Console.Write("Qual sua velocidade média por hora durante a viagem? ");
                    int.TryParse(Console.ReadLine(), out int velocidade);

                    consumo = Calculo(horas, velocidade);

                    Console.WriteLine($"Irei gastar em média { consumo.ToString("N3").Replace(".", "") } litros nessa viagem.");
                    Console.WriteLine("Para sair do programa pressione ESC\n");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
