Calculator calculator = new Calculator();
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Add : {a} + {b} = {calculator.Add(a,b)}");
System.Console.WriteLine($"Subtract : {a} - {b} = {calculator.Subtract(a,b)}");
System.Console.WriteLine($"Multiply : {a} * {b} = {calculator.Multiply(a,b)}");
System.Console.WriteLine($"Division : {a} / {b} = {calculator.Division(a,b)}");


