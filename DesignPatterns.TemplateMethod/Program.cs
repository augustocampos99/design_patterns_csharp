
using DesignPatterns.TemplateMethod;

var discount1 = new CalculateDiscountOnHundred();
var discount2 = new CalculateDiscountFiveHundred();

Console.WriteLine(discount1.Calculate(20));
Console.WriteLine(discount1.Calculate(120));
Console.WriteLine(discount2.Calculate(550));
