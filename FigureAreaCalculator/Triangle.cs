using System;
using FigureAreaCalculator.Components.Data_Model;

namespace FigureAreaCalculator
{
    public class Triangle : IFigure
    {
        private double? _a;
        private double? _b;
        private double? _c;
        
        public Triangle() {}

        public Triangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a)
                throw new AggregateException("Impossible triangle side lengths");

            _a = a;
            _b = b;
            _c = c;
        }

        public double A
        {
            get => _a ?? 0;
            set => _a = value < 0 ? -value : value;
        }
        
        public double B
        {
            get => _b ?? 0;
            set => _b = value < 0 ? -value : value;
        }
        
        public double C
        {
            get => _c ?? 0;
            set => _c = value < 0 ? -value : value;
        }

        public bool IsRightTriangle
        {
            get
            {
                if (_a == null || _b == null || _c == null)
                    throw new ArgumentNullException(_a == null ? nameof(A) : _b == null ? nameof(B) : nameof(C));

                return Math.Abs(A * A + B * B - C * C) == 0 || 
                       Math.Abs(A * A + C * C - B * B) == 0 ||
                       Math.Abs(C * C + B * B - A * A) == 0;
            }
        }
        
        public double Area()
        {
            if (_a == null || _b == null || _c == null)
                throw new ArgumentNullException(_a == null ? nameof(A) : _b == null ? nameof(B) : nameof(C));

            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}