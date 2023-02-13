//Math rohkem 90, Biologia rohkem 90...

int math, biology, chemistry;

Console.WriteLine("Math res");
math = Int32.Parse(Console.ReadLine());
Console.WriteLine("Bio res");
biology = Int32.Parse(Console.ReadLine());
Console.WriteLine("Chem res");
chemistry = Int32.Parse(Console.ReadLine());

if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Годен");
}    
else
{
    Console.WriteLine("Ur application is not approved");
}    