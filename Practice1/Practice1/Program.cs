//// Practice 1
//int temperature = 0;

//while (true)
//{
//    Console.Write("Write temperature: ");

//    if (IsValidInputStr(Console.ReadLine()))
//    {
//        Console.WriteLine(CalculateTemperatureStr(temperature));
//        break;
//    }
//}

//bool IsValidInputStr(string? inputStr)
//{
//    if (int.TryParse(inputStr, out temperature))
//        return true;

//    return false;
//}

//string CalculateTemperatureStr(int temperature)
//{
//    if (temperature < 0)
//        return "It's freezing";
//    else if (temperature >= 0 && temperature <= 30)
//        return "It's good weather";
//    else
//    {
//        return "It's hot";
//    }
//}


//string? inputStr;
//bool startGame = true;

//while (startGame)
//{
//    Console.WriteLine("Options:\n1. stone\n2. scissors\n3. paper\n");
//    Console.Write("Write your world: ");
//    inputStr = Console.ReadLine();

//	if (!IsUserInputValid(inputStr))
//	{
//        Console.WriteLine("Incorrect word!!!\n");
//    }

//	else
//	{
//		string? computerStr = GenerateComputerTurn();

//        Console.WriteLine($"User: {inputStr} - {computerStr} Computer");

//		if (IsDraw(inputStr, computerStr))
//		{
//			Console.WriteLine("Game result: Draw!");
//		}

//		else if (IsUserWon(inputStr, computerStr))
//		{
//			Console.WriteLine("Game result: User wons!");
//		}

//		else if (IsComputerWon(inputStr, computerStr))
//		{
//			Console.WriteLine("Game result: Computer wons!");
//		}

//		else
//		{
//            Console.WriteLine("Error game proccess");
//        }

//        Console.Write("\nPlay again? y/n: ");
//		if (Console.ReadLine().Equals("y"))
//			continue;
//		else
//		{
//            Console.WriteLine("\nEnd game...");
//            break;
//		}
//    }
//}

//bool IsUserInputValid(string? inputStr)
//{
//	switch (inputStr)
//	{
//		case "stone":
//			return true;
//		case "scissors":
//			return true;
//		case "paper":
//			return true;

//		default:
//			return false;
//	}
//}

//// If user wons - returns true, else return false
//string? GenerateComputerTurn()
//{
//    Random random = new Random();

//	switch (random.Next(0, 2))
//	{
//		case 0:
//			return "stone";
//		case 1:
//			return "scissors";
//		case 2:
//			return "paper";

//		default:
//			return null;
//    }
//}

//bool IsUserWon(string? userStr, string? computerStr)
//{
//	if (userStr.Equals("stone") && computerStr.Equals("scissors"))
//		return true;
//	else if (userStr.Equals("scissors") && computerStr.Equals("paper"))
//		return true;
//	else if (userStr.Equals("paper") && computerStr.Equals("stone"))
//		return true;

//	return false;
//}

//bool IsComputerWon(string? userStr, string? computerStr)
//{
//    if (computerStr.Equals("stone") && userStr.Equals("scissors"))
//        return true;
//    else if (computerStr.Equals("scissors") && userStr.Equals("paper"))
//        return true;
//    else if (computerStr.Equals("paper") && userStr.Equals("stone"))
//        return true;

//    return false;
//}

//bool IsDraw(string? userStr, string? computerStr) => userStr.Equals(computerStr);


int year = 0;

while (true)
{
    Console.Write("Enter a year: ");
    if (!int.TryParse(Console.ReadLine(), out year))
        continue;
    else
    {
        CalculateZodiac(year);
        break;
    }
}

void CalculateZodiac(int year)
{
    string[] animals = {
            "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox",
            "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep"};

    string zodiacName = animals[year % 12];
    Console.WriteLine($"The Chinese zodiac sign for {year} is {zodiacName}.");
}
