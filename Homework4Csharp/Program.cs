using System;

namespace Program;

struct Point
{
    private int X { get; set; }
    private int Y { get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int _x, int _y)
    {
        X = _x;
        Y = _y;
    }

}

class Counter
{
    private int Min;
    private int Max;
    private int Cur;


    public Counter(int min, int max)
    {
        Min = min;
        Max = max;
        Cur = min;
    }

    public void Increment()
    {
        if (Cur < Max)
            Cur++;
        else Cur = Min;

    }
    public void Decrement()
    {
        if (Cur > Min)
            Cur--;
        else Cur = Max;
    }

    public int getCurrent()
    {
        return Cur;
    }
}

class Program
{
    static void Main()
    {
        Counter counter = new Counter(1, 5);
        //counter.Increment();
        counter.Decrement();
        //counter.Decrement();
        Console.WriteLine(counter.getCurrent());

    }
}
