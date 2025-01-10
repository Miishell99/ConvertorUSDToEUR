//input
int countOfPagesToRead = int.Parse(Console.ReadLine());
int pagesReadPerOneHour = int.Parse(Console.ReadLine());
int countOfDays = int.Parse(Console.ReadLine());

//calculate
int neededHours = countOfPagesToRead / pagesReadPerOneHour;
int readingHoursPerDay = neededHours / countOfDays;
//ouput
Console.WriteLine(readingHoursPerDay);