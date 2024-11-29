using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Test;

/// <summary>
/// Тесты фигуры "круг"
/// </summary>
public class CircleTests
{
    /// <summary>
    /// Создание фигуры с ошибкой
    /// </summary>
    /// <param name="radius">радиус</param>
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-100)]
    public void CreateCircle_InvalidValues_ReturnThrow(double radius)
    {
        Assert.Throws<AggregateException>(() => new Circle(radius));
    }
    
    /// <summary>
    /// Создание фигуры без ошибки
    /// </summary>
    /// <param name="radius">радиус</param>
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(100)]
    public void CreateCircle_CorrectValues_ReturnWithoutThrow(double radius)
    {
        Assert.NotNull(new Circle(radius));
    }

    /// <summary>
    /// Подсчет площади
    /// </summary>
    /// <param name="radius">радиус</param>
    /// <param name="expected">ожидаемое значение</param>
    [Theory]
    [InlineData(4, 50.26548245743669)]
    [InlineData(5, 78.53981633974483)]
    public void CircleArea_ReturnResult(double radius, double expected)
    {
        var circle = new Circle(radius);
        Assert.Equal(expected, circle.Area());
    }
}