using System;
using System.Collections.Generic;
using System.Text;


enum Shapes
{
    Triangle,
    Square,
   // Circle
}

// Does not follow Open-Closed Principle
class Shape
{
    public void GetArea(Shapes shapes)
    {
        if (shapes == Shapes.Triangle)
        {
            Console.WriteLine("Triangle");
        }
        else if (shapes == Shapes.Square)
        {
            Console.WriteLine("Square");
        }
    }
}

