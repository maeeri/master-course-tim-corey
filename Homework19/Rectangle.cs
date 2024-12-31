namespace Homework19
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
