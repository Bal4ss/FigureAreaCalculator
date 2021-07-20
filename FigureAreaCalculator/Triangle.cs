using System;
using FigureAreaCalculator.Components.Data_Model;

namespace FigureAreaCalculator
{
    /// <summary>
    /// Фигура - треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">Значение первой стороны треугольника</param>
        /// <param name="b">Значение второй стороны треугольника</param>
        /// <param name="c">Значение третьей стороны треугольника</param>
        /// <exception cref="AggregateException">Указаны невозможные для треугольника значения сторон</exception>
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a)
                throw new AggregateException("Impossible triangle side lengths");

            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double A
        {
            get => _a;
            set => _a = value < 0 ? -value : value;
        }
        
        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double B
        {
            get => _b;
            set => _b = value < 0 ? -value : value;
        }
        
        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double C
        {
            get => _c;
            set => _c = value < 0 ? -value : value;
        }

        /// <summary>
        /// Проверка на прямоугольность 
        /// </summary>
        public bool IsRightTriangle
            => Math.Abs(A * A + B * B - C * C) == 0 ||
               Math.Abs(A * A + C * C - B * B) == 0 ||
               Math.Abs(C * C + B * B - A * A) == 0;

        /// <summary>
        /// Метод вычисления площади треугольника
        /// </summary>
        /// <returns>Значение площади треугольника</returns>
        public double Area()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}