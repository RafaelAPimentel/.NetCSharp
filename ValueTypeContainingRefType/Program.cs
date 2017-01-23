using System;

public class ShapeInfo
{

    public string infoString;
    public ShapeInfo(string info)
    {
        infoString = info;

    }


    struct Rectangle
    {
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectRight, rectBottom;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top; rectBottom = bottom;
            rectLeft = left; rectRight = right;

        }

        public void display()
        {
            Console.WriteLine("String: {0}, Top: {1}, Bottom: {2}, Left: {3}, Right: {4}", rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }


    }

    static void ValueTypeContainingRefType()
    {
        Console.WriteLine("=> Creating Rect1");
        Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

        //
        Console.WriteLine("=> Assigning r2 to r1");
        Rectangle r2 = r1;

        Console.WriteLine("=> changing values of r2");
        r2.rectInfo.infoString = "This is new info";
        r2.rectBottom = 4444;


        r1.display();
        r2.display();

    }

    static void Main(string[] args)
    {
        ValueTypeContainingRefType();
        Console.ReadKey();
    }
}