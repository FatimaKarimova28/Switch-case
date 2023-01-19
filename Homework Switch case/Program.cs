

 Console.WriteLine("Birinci ededi daxil edin:");
double number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ikinci ededi daxil edin:");
double number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hansi emeliyyati aparmaq istədiyinizi daxil edin:");
var operation = (Console.ReadLine());
{
    switch (operation)
    {
        case "+":
            Console.WriteLine(number1 + number2); break;
        case "-": Console.WriteLine(number1 - number2); break;
        case "*": Console.WriteLine(number1 * number2); break;
        case "/": Console.WriteLine(number1 / number2); break;
        default:
            Console.WriteLine("Secim yanlishdir");

            break;
    }
}

   



