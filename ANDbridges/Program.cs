//temp <= 0 * freesing cold
//temp > 0 AND temp <= 10 -cold
//temp > 10 AND temp <= 15 -chilly
//temp > 15 AND temp < 20 -Warm
//temp >= 20 AND temp < 30 -Hot
//temp >= 30 * boiling hot

Console.WriteLine("Temperature");
int temp = Int32.Parse(Console.ReadLine());

if(temp >= 30)
{
    Console.WriteLine("Boiling hot");
}    
else if(temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("warm");
}    
else if(temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly");
}   
else if(temp < 10 && temp > 0)
    {
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("Freezing cold");
}    