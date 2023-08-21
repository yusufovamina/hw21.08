//не знаю должны ли числа вводится с консоли или нет, поэтому сделала оба варианта
//1
int number;
number = Convert.ToInt32(Console.ReadLine());
ushort persantage;
persantage = Convert.ToUInt16(Console.ReadLine());

//2
//int number =90;
//ushort persantage=10;
Console.WriteLine(persantage+"% of "+number+" is "+(number*persantage/100));
