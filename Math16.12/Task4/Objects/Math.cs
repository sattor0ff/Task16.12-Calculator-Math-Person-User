public class Math
{
    private double PI = 3.14;
    private double E = 2.71;

public double Abs(double value)
{
    if(value<0)
    {
        value = 1*(-value);
    }
    return value;
}
public float Abs(float value)
{
    if(value<0)
    {
        value = 1*(-value);
    }
    return value;
}
public short Abs(short value)
{
    if(value<0)
    {
       return  (short)(value *-1);
    }
    return (short) value;
}
public int Abs(int value)
{
    if(value<0)
    {
        value = 1*(-value);
    }
    return value;
}
public double Pow(double x, double y)
{
    double sumPow = 0;
    for(int i = 1; i<=y; i++)
    {
        sumPow = sumPow + x*x;
    }
    return sumPow;
}

public double Sqrt(double d)
{
    double resSqrt= 0;
    for(int i = 1; i<=d; i++)
    if(i * i == d)
    {
        resSqrt = i;
        break;
    }
    if(resSqrt == 0)
    {
        System.Console.WriteLine($"Can't find Sqrt of {d}");
    }
    return resSqrt;
}

public int Max(int val1, int val2)
{
    int resMax;
    if(val1>val2)
    {
        resMax = val1;
    }
    else
    {
        resMax =val2;
    }
    return resMax;
}

public int Min(int val1, int val2)
{
    int resMin;
    if(val1<val2)
    {
        resMin = val1;
    }
    else
    {
        resMin =val2;
    }
    return resMin;
}
}