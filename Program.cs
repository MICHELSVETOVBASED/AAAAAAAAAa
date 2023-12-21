using System;
using System.Collections.Generic;
using System.Data.Common;


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

        Coordinates coordinates = new Coordinates();
        coordinates.x = list[0];
        coordinates.y = list[1];
        coordinates.z = list[2];
        Coordinates  coordinates1 = new Coordinates();
        coordinates1.x = list1[0];
        coordinates1.y = list1[1];
        coordinates1.z = list1[2];
    }
}

public class Coordinates
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }
}
class Fly
{
    public Coordinates Coordinates{ get; set; }
    {
        
    }
}