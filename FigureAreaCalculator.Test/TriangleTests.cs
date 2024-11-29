using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Test;

/// <summary>
/// Тесты фигуры "треугольник"
/// </summary>
public class TriangleTests
{
    /// <summary>
    /// Создание фигуры с ошибкой
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    /// <param name="c">сторона C</param>
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-1, -1, -1)]
    [InlineData(1, 1, -1)]
    [InlineData(-1, 1, 1)]
    [InlineData(1, -1, 1)]
    [InlineData( 1, 2, 6)]
    public void CreateTriangle_InvalidValues_ReturnThrow(double a, double b, double c)
    {
        Assert.Throws<AggregateException>(() => new Triangle(a, b, c));
    }
    
    /// <summary>
    /// Создание фигуры без ошибки
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    /// <param name="c">сторона C</param>
    [Theory]
    [InlineData(5, 4, 6)]
    public void CreateTriangle_CorrectValues_ReturnWithoutThrow(double a, double b, double c)
    {
        Assert.NotNull(new Triangle(a, b, c));
    }

    /// <summary>
    /// Подсчет площади
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    /// <param name="c">сторона C</param>
    /// <param name="expected">ожидаемое значение</param>
    [Theory]
    [InlineData(5, 4, 6, 9.9215674164922145)]
    public void TriangleArea_ReturnResult(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expected, triangle.Area());
    }
    
    /// <summary>
    /// Проверка на то, является ли треугольник прямоугольным
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    /// <param name="c">сторона C</param>
    /// <param name="expected">ожидаемое значение</param>
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(4, 5, 3, true)]
    [InlineData(12, 13, 5, true)]
    [InlineData(11, 13, 6, false)]
    public void TriangleIsRight_ReturnResult(double a, double b, double c, bool expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expected, triangle.IsRightTriangle);
    }
}