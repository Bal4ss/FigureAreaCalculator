using FigureAreaCalculator.Core.Abstractions.Services;
using FigureAreaCalculator.Core.Figures;
using FigureAreaCalculator.Core.Services;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Test;

public class FigureServiceTests
{
    private readonly IFigureService _figureService;
    
    public FigureServiceTests()
    {
        _figureService = new FigureService();
    }
    
    /// <summary>
    /// Подсчет площади треугольника
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
        Assert.Equal(expected, _figureService.Area(triangle));
    }
    
    /// <summary>
    /// Подсчет площади круга
    /// </summary>
    /// <param name="radius">радиус</param>
    /// <param name="expected">ожидаемое значение</param>
    [Theory]
    [InlineData(4, 50.26548245743669)]
    public void CircleArea_ReturnResult(double radius, double expected)
    {
        var circle = new Circle(radius);
        Assert.Equal(expected, _figureService.Area(circle));
    }
    
    /// <summary>
    /// Подсчет площади прямоугольника
    /// </summary>
    /// <param name="a">сторона A</param>
    /// <param name="b">сторона B</param>
    /// <param name="expected">ожидаемое значение</param>
    [Theory]
    [InlineData(2, 2, 4)]
    public void RectangleArea_ReturnResult(double a, double b, double expected)
    {
        var rectangle = new Rectangle(a, b);
        Assert.Equal(expected, _figureService.Area(rectangle));
    }
}