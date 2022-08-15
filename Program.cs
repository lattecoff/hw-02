// See https://aka.ms/new-console-template for more information

/**
 * @file Program.cs.
 * @brief hw-02.
 * @details
 * Программа принимает и проверяет значение типа byte   byte, sbyte, short, ushort, int, uint, long, ulong
 * возможно ли явное приведение к перечмсленным типам без потери точности и \n
 * если да - выполняет привежение и выводит результат \n
 * если нет - выводит сообщение вида \n
 * "Для приведение числа {X} к типу {T} число не может быть больше {A} и меньше {B}"
 */

byte   byteNum   = 0;
sbyte  sbyteNum  = 0;
short  shortNum  = 0;
ushort ushortNum = 0;
int    intNum    = 0;
uint   uintNum   = 0;
long   longNum   = 0;
ulong  ulongNum  = 0;

Console.WriteLine("Введите целое число...");
string inputValue = Console.ReadLine();

Console.WriteLine();

if (byte.TryParse(inputValue, out byteNum))
{
	Console.WriteLine(byteNum + (" byte OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + byte.MaxValue + " и меньше " + byte.MinValue); 
}

if (sbyte.TryParse(inputValue, out sbyteNum))
{
	Console.WriteLine(sbyteNum + (" sbyte OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + sbyte.MaxValue + " и меньше " + sbyte.MinValue);
}

if (short.TryParse(inputValue, out shortNum))
{
	Console.WriteLine(shortNum + (" short OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + short.MaxValue + " и меньше " + short.MinValue);
}

if (ushort.TryParse(inputValue, out ushortNum))
{

	Console.WriteLine(ushortNum + (" ushort OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + ushort.MaxValue + " и меньше " + ushort.MinValue);
}

if (int.TryParse(inputValue, out intNum))
{

	Console.WriteLine(intNum + (" int OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + int.MaxValue + " и меньше " + int.MinValue);
}

if (uint.TryParse(inputValue, out uintNum))
{

	Console.WriteLine(uintNum + (" uint OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + uint.MaxValue + " и меньше " + uint.MinValue);
}

if (long.TryParse(inputValue, out longNum))
{

	Console.WriteLine(longNum + (" long OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + long.MaxValue + " и меньше " + long.MinValue);
}

if (ulong.TryParse(inputValue, out ulongNum))
{

	Console.WriteLine(ulongNum + (" ulong OK"));
}
else
{
	Console.WriteLine("Для приведения числа " + inputValue + " к типу byte число не может быть больше " + ulong.MaxValue + " и меньше " + ulong.MinValue);
}

Console.ReadKey();
