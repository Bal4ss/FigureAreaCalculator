using FigureAreaCalculator.Abstractions.Figures;
using FigureAreaCalculator.Core.Abstractions.Services;

namespace FigureAreaCalculator.Core.Services;

public class FigureService : IFigureService
{
    public double Area(IFigure figure)
    {
        return figure.Area();
    }
}