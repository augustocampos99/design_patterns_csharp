


using DesignPatterns.Decorator;

Console.WriteLine(new CalculateISS(new CalculateIR(new CalculateIOF(null))).Calculate(100));







