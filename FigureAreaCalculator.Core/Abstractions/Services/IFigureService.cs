using FigureAreaCalculator.Abstractions.Figures;

namespace FigureAreaCalculator.Core.Abstractions.Services;

/// <summary>
/// Сервис для работы с фигурами
/// </summary>
public interface IFigureService
{
    /// <summary>
    /// Вычисление площади фигуры
    /// </summary>
    /// <param name="figure">фигура</param>
    /// <returns>площадь фигуры</returns>
    double Area(IFigure figure);
}