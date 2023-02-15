System.Console.WriteLine("Введите 3х значное число");
int value = Convert.ToInt32(Console.ReadLine());

value = value / 10 % 10 ;

System.Console.WriteLine($"{value} это вторая цифра введенного числа");