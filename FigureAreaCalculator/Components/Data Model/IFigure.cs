namespace FigureAreaCalculator.Components.Data_Model
{
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
}