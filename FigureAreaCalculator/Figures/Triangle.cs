using FigureAreaCalculator.Abstractions.Figures;

namespace FigureAreaCalculator.Figures;

/// <summary>
/// Фигура - треугольник
/// </summary>
public class Triangle : IFigure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    
    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="a">Значение первой стороны треугольника</param>
    /// <param name="b">Значение второй стороны треугольника</param>
    /// <param name="c">Значение третьей стороны треугольника</param>
    /// <exception cref="AggregateException">Указаны невозможные для треугольника значения сторон</exception>
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0 || a + b < c || a + c < b || b + c < a)
            throw new AggregateException("Impossible triangle side length");

        _a = a;
        _b = b;
        _c = c;
    }

    /// <summary>
    /// Проверка на прямоугольность 
    /// </summary>
    public bool IsRightTriangle
        => (_a * _a + _b * _b).Equals(_c * _c) ||
           (_a * _a + _c * _c).Equals(_b * _b) ||
           (_c * _c + _b * _b).Equals(_a * _a);
    
    public double Area()
    {
        var p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }
}