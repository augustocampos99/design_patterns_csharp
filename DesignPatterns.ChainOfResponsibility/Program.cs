using DesignPatterns.ChainOfResponsibility;

var discount1 = new DiscountOneHundred();
var discount2 = new DiscountFiveHundred();
var discountDefault = new DiscountDefault();


discount1.NextDiscount = discount2;
discount2.NextDiscount = discountDefault;

Console.WriteLine(discount1.Calculate(50));
Console.WriteLine(discount1.Calculate(200));
Console.WriteLine(discount1.Calculate(600));


