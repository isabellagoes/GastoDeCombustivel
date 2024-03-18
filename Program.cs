using System.Globalization;

int horas, velKM;
double distancia, litros;

Console.WriteLine("Considerando um automóvel que faz 12km/l; informe a quantidade de horas gastas e a velcoidade média (em km/h) em uma viagem a fim de efetuar o cálculo do gasto total de litros de combustível: \n");

Console.Write("Horas gastas: ");
horas = Convert.ToInt16(Console.ReadLine());

Console.Write("Velocidade média (em km/h): ");
velKM = Convert.ToInt16(Console.ReadLine());
        
distancia = velKM * horas;
litros = distancia / 12;
		
Console.WriteLine($"\nForam gastos na viagem {litros.ToString("F3")}l.");

