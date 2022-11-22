
using DesignPatterns.Strategy;

var budget = new Budget(100.00);

var iss = new ISS();
var icms = new ICMS();

Console.WriteLine(new CalculateTax().Calculate(budget, icms));
Console.WriteLine(new CalculateTax().Calculate(budget, iss));


