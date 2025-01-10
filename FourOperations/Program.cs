// input
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
//calculate
double addResult = firstNumber + secondNumber;
double subtractResult = firstNumber - secondNumber;
double multiplyResult = firstNumber * secondNumber;
double divideResult = firstNumber / secondNumber;
//output
Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {addResult:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {subtractResult:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {multiplyResult:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {divideResult:F2}");