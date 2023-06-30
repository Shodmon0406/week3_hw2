public class Circle : Shape
{
    double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
    public override double Perimetr()
    {
        return 2 * Math.PI * _radius;
    }
}