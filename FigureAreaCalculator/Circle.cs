using System;
using FigureAreaCalculator.Components.Data_Model;

namespace FigureAreaCalculator
{
    public class Circle : IFigure
    {
        private double? _radius;

        public Circle() {}

        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public double Radius
        {
            get => _radius ?? 0;
            set => _radius = value > 0 ? value : -value;
        }
        
        public double Area()
            => _radius == null
                ? throw new ArgumentNullException(nameof(Radius))
                : Math.PI * Radius * Radius;
    }
}