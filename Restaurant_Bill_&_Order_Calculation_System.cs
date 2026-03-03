int hamburgerPrice;
int cokePrice;
int waterPrice;
int friesPrice;
int pizzaPrice;
int lemonadePrice;

hamburgerPrice = 300;
cokePrice = 35;
waterPrice = 15;
friesPrice = 50;
pizzaPrice = 100;
lemonadePrice = 75;

int pizzaCount;
int hamburgerCount;
int cokeCount;
int friesCount;
int lemonadeCount;
int waterCount;

pizzaCount = 3;
hamburgerCount = 4;
cokeCount = 2;
friesCount = 6;
lemonadeCount = 0;
waterCount = 4;

int totalHamburgerPrice = hamburgerCount * hamburgerPrice ;
int totalWaterPrice = waterCount * waterPrice ;
int totalPizzaPrice = pizzaCount * pizzaPrice ;
int totalFriesPrice = friesCount * friesPrice ;
int totalLemonadePrice = lemonadeCount * lemonadePrice ;
int totalCokePrice = cokeCount * cokePrice ;

int totalPrice;
totalPrice = totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;


Console.WriteLine();
Console.WriteLine("Yenilen Hamburger Tutarı: " + totalHamburgerPrice);
Console.WriteLine("Yenilen Pizza Tutarı: " + totalPizzaPrice);
Console.WriteLine("Yenilen Su Tutarı: " + totalWaterPrice);
Console.WriteLine("Yenilen Limonata Tutarı: " + totalLemonadePrice);
Console.WriteLine("Yenilen Kola Tutarı: " + totalCokePrice);
Console.WriteLine("Yenilen Kızartma Tutarı: " + totalFriesPrice);
Console.WriteLine();
Console.WriteLine("Hesap: " + totalPrice);
