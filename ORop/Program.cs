//math r90 OR Chem r90 OR Bio r90

//math && chem || math && bio || chem && bio
int math, biology, chemistry;

Console.WriteLine("Math res");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("BIo res");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Chem res");
chemistry = Int32.Parse(Console.ReadLine());

if((math >= 90 && chemistry >= 90) || (math >= 90 && biology >=90) || (chemistry >= 90 && biology >=90))
{
    Console.WriteLine("Sobib");
}
else
{
    Console.WriteLine("Ei sobi");
}