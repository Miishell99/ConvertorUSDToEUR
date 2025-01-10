//input
double depositAmount = double.Parse(Console.ReadLine());
int countOfMonths = int.Parse(Console.ReadLine());
double interestPercentPerYear = double.Parse(Console.ReadLine());
//calculate
double yearIncome = depositAmount * interestPercentPerYear / 100;
double monthIncome = yearIncome / 12;
double finalAmount = depositAmount + (countOfMonths * monthIncome);
//output
Console.WriteLine($"{finalAmount:F2}");