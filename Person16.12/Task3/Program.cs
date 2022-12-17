Person person = new Person();

person.Name = Console.ReadLine();
person.Age = Console.ReadLine();
person.Height = Convert.ToSingle(Console.ReadLine());
person.Weight = Convert.ToByte(Console.ReadLine());
System.Console.WriteLine($"{person.Name} | {person.Age} y.o | {person.Height}cm | {person.Weight}kg");

System.Console.WriteLine();

person.Walk();
person.Talk();
person.Eat();
person.Sleep();


