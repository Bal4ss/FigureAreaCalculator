namespace FigureAreaCalculator.Abstractions.Figures;

/// <summary>
/// Интерфейс фигуры
/// </summary>
public interface IFigure
{
    /// <summary>
    /// Метод вычисления площади фигуры
    /// </summary>
    /// <returns>Значение площади</returns>
    double Area();
}