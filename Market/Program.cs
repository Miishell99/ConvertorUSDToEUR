//input
double tomatoPricePerKg = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPricePerKg = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());
//calculate
double tomatoPrice = tomatoPricePerKg * tomatoQuantity;
double cucumberPrice = cucumberPricePerKg * cucumberQuantity;
double finalPrice = tomatoPrice + cucumberPrice;
//output
Console.WriteLine($"{finalPrice:F2}");