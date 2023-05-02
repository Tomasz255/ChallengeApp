var name = "Ewa";
var surname = "Belek";
var sex = false;
var age = 16;

if (sex == false)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine(name + ", lat " + age);
    }
}
else
{


    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine(name + ", lat " + age);
    }


}