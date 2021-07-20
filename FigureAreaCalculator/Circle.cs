using System;
using FigureAreaCalculator.Components.Data_Model;

namespace FigureAreaCalculator
{
    /// <summary>
    /// Фигура - окружность
    /// </summary>
    public class Circle : IFigure
    {
        private double _radius;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            _radius = radius > 0 ? radius : -radius;
        }
        
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius
        {
            get => _radius;
            set => _radius = value > 0 ? value : -value;
        }
        
        /// <summary>
        /// Метод вычисления площади окружности
        /// </summary>
        /// <returns>Значение площади окружности</returns>
        public double Area()
            => Math.PI * Radius * Radius;
    }
}