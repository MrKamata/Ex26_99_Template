using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(
                InteractiveInput.InputFloat("底辺："),
                InteractiveInput.InputFloat("高さ："));
            Console.WriteLine($"面積は{triangle1.GetSurface()}");
        }
    }
}