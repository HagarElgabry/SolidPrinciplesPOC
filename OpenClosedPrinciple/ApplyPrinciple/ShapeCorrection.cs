using System;
using System.Collections.Generic;
using System.Text;

interface IShape
{
    public void GetArea();
}
class Square : IShape
{
    public void GetArea()
    {
        Console.WriteLine("Square");
    }
}
class Triangle : IShape
{
    public void GetArea()
    {
        Console.WriteLine("Triangle");
    }
}
class ShapeCorrection
{
    public void GetArea(IShape shape)
    {
        shape.GetArea();
    }
}