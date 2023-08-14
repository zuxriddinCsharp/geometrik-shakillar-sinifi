namespace geometrik_shakillar_sinifi
{
    class Rectagle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectagle()
        {
            Width = 0;
            Height = 0;
        }
        public Rectagle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
        public double CalculateDioganal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }
    }
    class Circle
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculatePerimetr()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectagle rectagle = new Rectagle(10, 20);
            Console.WriteLine("Rectangle");
            Console.WriteLine($"Perimetr:  {rectagle.CalculatePerimeter()}");
            Console.WriteLine($"Area:  {rectagle.CalculateArea()}");
            Console.WriteLine($"Diaganal:  {rectagle.CalculateDioganal()}");

            Circle circle = new Circle(9);
            Console.WriteLine("\nCircle");
            Console.WriteLine($"Perimetr:  {circle.CalculatePerimetr()}");
            Console.WriteLine($"Area:  {circle.CalculateArea()}");
        }
    }
}