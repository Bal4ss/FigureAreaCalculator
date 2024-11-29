using FigureAreaCalculator.Core.Figures;

namespace FigureAreaCalculator.Test;

/// <summary>
/// Тесты фигуры "прямоугольник"
/// </summary>
public class RectangleTests
{
    /// <summary>
    /// Создание фигуры с ошибкой
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    [Theory]
    [InlineData(0, 0)]
    [InlineData( 1, -2)]
    [InlineData( -1, 2)]
    [InlineData( -1, -2)]
    public void CreateRectangle_InvalidValues_ReturnThrow(double a, double b)
    {
        Assert.Throws<AggregateException>(() => new Rectangle(a, b));
    }
    
    /// <summary>
    /// Создание фигуры без ошибки
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    [Theory]
    [InlineData(1, 2)]
    [InlineData(1, 1)]
    public void CreateRectangle_CorrectValues_ReturnWithoutThrow(double a, double b)
    {
        Assert.NotNull(new Rectangle(a, b));
    }

    /// <summary>
    /// Подсчет площади
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    /// <param name="expected">ожидаемое значение</param>
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    public void RectangleArea_ReturnResult(double a, double b, double expected)
    {
        var rectangle = new Rectangle(a, b);
        Assert.Equal(expected, rectangle.Area());
    }
    
    /// <summary>
    /// Проверка на то, является ли прямоугольник правельным
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    /// <param name="expected">ожидаемое значение</param>
    [Theory]
    [InlineData(2, 2, true)]
    [InlineData(11, 13, false)]
    public void RectangleIsRight_ReturnResult(double a, double b, bool expected)
    {
        var triangle = new Rectangle(a, b);
        Assert.Equal(expected, triangle.IsRightRectangle);
    }
}