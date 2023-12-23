using System;
using System.Collections.Generic;
using static System.Math;




public class Solution {
    static void Main(string[] args) {
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();
        string[] inputs = Console.ReadLine().Split(' ');
        string[] inputs1 = Console.ReadLine().Split(' ');
        for (int i = 0; i < inputs.Length; i++)
        {
            list.Add(int.Parse(inputs[i]));
        }

        for (int i = 0; i < inputs1.Length; i++)
        {
            list1.Add(int.Parse(inputs1[i]));
        }
        
        Coordinates coordinates = new Fly(list[0],list[1], list[2]);//прописыванием каждое значение для класса
        Coordinates coordinates1 = new Spider(list1[0], list1[1], list1[2]);
        double d = Sqrt(Pow((coordinates.X - coordinates1.X), 2) + Pow((coordinates.Y - coordinates1.Y), 2) +
                        Pow((coordinates.Z - coordinates1.Z), 2));

        if ( coordinates.X-coordinates1.X==0 && )
        Console.WriteLine(d);
        Console.WriteLine(p);


    }
}

public class Coordinates
{
    public Coordinates(int x, int y, int z) // то есть что вмещает в себя этот класс, так как не можем написать в объявлении класса
    {//создаются эти значения при условиях компонента общего класса
        X = x;
        Y = y;
        Z = z;
    }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    
}
public class Fly : Coordinates
{
    public Fly(int x, int y, int z) : base(x, y, z)
    {
    }
}

class Spider : Coordinates
{
    public Spider(int x, int y, int z) : base(x, y, z)
    {
    }
}