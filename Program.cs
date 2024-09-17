Console.WriteLine("welcome to Sherlenthia sandwitch shop ");
double baseCost;
const double Cost_OF_Sandwitch = 4.75;
const double Cost_OF_Topping = 0.55;
const double Discount_Amount= .10;
double orderCost;


double  sandwitchTotal = GetSandwicth()*Cost_OF_Sandwitch;
Console.WriteLine(sandwitchTotal);
double toppingsTotal = GetToppings()*Cost_OF_Topping;

Console.WriteLine(toppingsTotal);
baseCost = GetBase(sandwitchTotal, toppingsTotal);

Console.WriteLine("how much would you like to tip");
double tipPercent= double.Parse(Console.ReadLine());

orderCost = tipPercent+(baseCost *(1-Discount_Amount));
Console.WriteLine(orderCost);

 

static int GetSandwicth()
{
    Console.WriteLine("how many sandwitches are you getting");
     return int.Parse(Console.ReadLine());
     
     


}

static int GetToppings()
{
    Console.WriteLine("how many toppings are you getting");
     return int.Parse(Console.ReadLine());

}

static double  GetBase(double sandwitch , double toppings){
    return sandwitch + toppings ;

}
 

