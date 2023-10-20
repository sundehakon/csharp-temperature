Console.Write("Skriv inn et tall:");
string? tall = Console.ReadLine();

try
{
    if (decimal.TryParse(tall, out decimal celsius)) 
    {
        decimal fahrenheit = celsius * 9m / 5m + 32m;
        decimal kelvin = celsius + 273.15m;


        Console.WriteLine("Du valgte {0}", tall);
        Console.WriteLine("Temperaturen i celsius: {0}°C", celsius);
        Console.WriteLine("Temperaturen i fahrenheit: {0}°F", fahrenheit);
        Console.WriteLine("Temperaturen i kelvin: {0} K", kelvin);
    }
    else
    {
        throw new Exception("Ugyldig input, skriv inn et tall.");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
