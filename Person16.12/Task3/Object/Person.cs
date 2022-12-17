public class Person
{
    public string Name;
    public string Age;
    public float Height;
    public byte Weight;

    public void Walk()
    {
        System.Console.WriteLine($"{Name} is walking.");
    }
    public void Talk()
    {
        System.Console.WriteLine($"{Name} is talking.");
    }
    public void Eat()
    {
        System.Console.WriteLine($"{Name} is eating.");
    }
    public void Sleep()
    {
        System.Console.WriteLine($"{Name} is sleeping.");
    }

}