//input
int countOfPensPackages = int.Parse(Console.ReadLine());
int countOfMarkersPackages = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());


//calculate
double priceForPens = countOfPensPackages * 5.80;
double priceForMarkers = countOfMarkersPackages * 7.20;
double priceForBoardCleaner = litersOfBoardCleaner * 1.20;

double priceForMaterials = priceForPens + priceForMarkers + priceForBoardCleaner;

double discount = priceForMaterials * discountPercentage / 100;
double finalPrice = priceForMaterials - discount;
//output
Console.WriteLine(finalPrice);