using System;

namespace ForestFire
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest(20,20);
            forest.PrintAllTree();
            forest.Run();

        }
    }
}
