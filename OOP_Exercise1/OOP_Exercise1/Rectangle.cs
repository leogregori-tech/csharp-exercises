internal class Rectangle
{
    public double Width;
    public double Height;

    public double areaCalc()
    {
        return Width * Height;
    }

    public double perimeterCalc()
    {
        return (Width * 2) + (Height * 2);
    }

    public double diagonalCalc()
    {
        return Math.Sqrt((Math.Pow(Width, 2) + (Math.Pow(Height, 2))));
    }
}