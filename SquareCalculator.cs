namespace SquareCalcLib
{
    public class SquareCalculator
    {
        /// <summary>
        /// Метод для подстчета площади произвольной фигуры
        /// </summary>
        /// <param name="args">Величины сторон фигуры
        /// 1 параметр - радиус круга
        /// 3 параметра - треугольик
        /// 4 параметра - четырехугольник</param>
        public static double SquareCalculate(params double[] args)
        {
            return args.Length switch
            {
                1 => Math.PI * Math.Pow(args[0], 2),
                3 => TriangleSquare(args),
                4 => QuadrilateralSquare(args),
                _ => throw new ArgumentException($"Введено неверное количество параметров сторон: {args.Length}шт"),
            };
        }

        /// <summary>
        /// Метод для подстчета площади произвольного треугольника
        /// </summary>
        private static double TriangleSquare(double[] sides)
        {
            double halfPerimetr = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - sides[0]) * (halfPerimetr - sides[1]) * (halfPerimetr - sides[2]));
        }

        /// <summary>
        /// Метод для подстчета площади произвольного четырехугольника
        /// </summary>
        private static double QuadrilateralSquare(double[] sides)
        {
            double halfPerimetr = (sides[0] + sides[1] + sides[2] + sides[3]) / 2;
            return Math.Sqrt((halfPerimetr - sides[0]) * (halfPerimetr - sides[1]) * (halfPerimetr - sides[2]) * (halfPerimetr - sides[3]));
        }


        // Вопрос 3:
        // В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в
        // одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
        // Если у продукта нет категорий, то его имя все равно должно выводиться.
        //
        // Если я правильно понял суть задания выборка уникальных пар значений должна быть из одной таблицы? Тогда запрос такой
        // SELECT DISTINCT ProductName, Category FROM Table
    }
}