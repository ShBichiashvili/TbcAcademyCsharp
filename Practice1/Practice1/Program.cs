int temperature = 0;

while (true)
{
    Console.Write("Write temperature: ");

    if (IsValidInputStr(Console.ReadLine()))
    {
        Console.WriteLine(CalculateTemperatureStr(temperature));
        break;
    }
}

bool IsValidInputStr(string? inputStr)
{
    if (int.TryParse(inputStr, out temperature))
        return true;

    return false;
}

string CalculateTemperatureStr(int temperature)
{
    if (temperature < 0)
        return "It's freezing";
    else if (temperature >= 0 && temperature <= 30)
        return "It's good weather";
    else
    {
        return "It's hot";
    }
}