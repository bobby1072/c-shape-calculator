namespace shapers;
public class Shape
{
    public string? shapename;
}
public class triangle : Shape
{
    public float? height;
    public float? basse;
    public float? area;
    public void tri_area()
    {
        area = (basse * height) / 2;
    }
}
public class rectangle : Shape
{
    public float? width;
    public float length;
    public float? area;
    public float? perimeter;
    public void rec_area()
    {
        area = length * width;
    }
    public void rec_perim()
    {
        perimeter = (2 * length) + (2 * width);
    }
}
public class circle : Shape
{
    public double? diameter;
    public double? area;
    public double? circumference;
    public const double pi = 3.1415926535897931;
    public void circ_cumferen()
    {
        circumference = pi * diameter;
    }
    public void circ_area()
    {
        area = pi * ((diameter / 2) * (diameter / 2));
    }

}
