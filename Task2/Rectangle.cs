public class Rectangle : Shape
{
    double _side1;
    double _side2;
    public Rectangle(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }
    public override double Area()
    {
        return _side1 * _side2;
    }
    public override double Perimetr()
    {
        return 2 * (_side1 + _side2);
    }
}