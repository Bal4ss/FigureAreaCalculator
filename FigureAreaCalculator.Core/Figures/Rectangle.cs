using FigureAreaCalculator.Abstractions.Figures;

namespace FigureAreaCalculator.Core.Figures;

/// <summary>
/// Фигура - прямоугольник
/// </summary>
public class Rectangle : IFigure
{
    private readonly double _a;
    private readonly double _b;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="a">Значение первой стороны прямоугольника</param>
    /// <param name="b">Значение второй стороны прямоугольника</param>
    /// <exception cref="AggregateException">Указаны невозможные для прямоугольника значения сторон</exception>
    public Rectangle(double a, double b)
    {
        if (a <= 0 || b <= 0)
            throw new AggregateException("Impossible rectangle side length");
        
        _a = a;
        _b = b;
    }

    /// <summary>
    /// Проверка на правильный прямоугольник
    /// </summary>
    public bool IsRightRectangle => _a.Equals(_b);
    
    public double Area()
    {
        return _a * _b;
    }
}