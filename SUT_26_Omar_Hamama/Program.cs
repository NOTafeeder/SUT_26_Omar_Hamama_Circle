namespace SUT_26_Omar_Hamama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            float area = circle.GetArea();
            Console.WriteLine($"Area of the circle: {area}");
            Circle circle2 = new Circle(6);
            float area2 = circle2.GetArea();
            Console.WriteLine($"Area of the second circle: {area2}");
        }
    }
}
