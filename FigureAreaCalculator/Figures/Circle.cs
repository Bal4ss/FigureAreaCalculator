using FigureAreaCalculator.Abstractions.Figures;

namespace FigureAreaCalculator.Figures;

/// <summary>
/// Фигура - окружность
/// </summary>
public sealed class Circle : IFigure
{
    private readonly double _radius;
    
    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="radius">Радиус окружности</param>
    /// <exception cref="AggregateException">Указаны невозможные для круга значения радиуса</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new AggregateException("Impossible circle radius");
            
        _radius = radius;
    }

    /// <summary>
    /// Метод вычисления площади окружности
    /// </summary>
    /// <returns>Значение площади окружности</returns>
    public double Area() => Math.PI * _radius * _radius;
}