namespace Polymorphism
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy Shape into clipboard");
        }

        public void Select()
        {
            System.Console.WriteLine("Select the Shape");
        }
    }

    public sealed class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Triangle");
        }
    }
}
