Math math = new Math();

System.Console.WriteLine();
System.Console.WriteLine("Double Abs:");
double doubleAbs;
doubleAbs = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(math.Abs(doubleAbs));


System.Console.WriteLine();
System.Console.WriteLine("Float Abs:");
double floatAbs;
floatAbs = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine(math.Abs(floatAbs));


System.Console.WriteLine();
System.Console.WriteLine("Short Abs:");
double shortAbs;
shortAbs = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine(math.Abs(shortAbs));


System.Console.WriteLine();
System.Console.WriteLine("Int Abs:");
int intAbs;
intAbs = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(math.Abs(intAbs));


System.Console.WriteLine();
System.Console.WriteLine("Pow:");
double powX, powY;
powX = Convert.ToDouble(Console.ReadLine());
powY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"{powX} pow {powY} = {math.Pow(powX, powY)}");


System.Console.WriteLine();
System.Console.WriteLine("Sqrt:");
double sqrtD;
sqrtD = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Sqrt of {sqrtD} is {math.Sqrt(sqrtD)}");


System.Console.WriteLine();
System.Console.WriteLine("Max: ");
int maxVal1, maxVal2;
maxVal1 = Convert.ToInt32(Console.ReadLine());
maxVal2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{math.Max(maxVal1, maxVal2)} is Max");


System.Console.WriteLine();
System.Console.WriteLine("Min: ");
int minVal1, minVal2;
minVal1 = Convert.ToInt32(Console.ReadLine());
minVal2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{math.Min(minVal1, minVal2)} is Min");