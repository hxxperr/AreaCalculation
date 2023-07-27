namespace AreaCalculation
{
    public interface CalculateAreaBehavier
    {
        public double AreaCalc(params double[] parameterArray);
    }
    public class CircleAreaCalc : CalculateAreaBehavier
    {
        /// <summary>
        /// Площадь круга по радиусу
        /// </summary>
        /// <param name="parameterArray">Радиус</param>
        /// <returns></returns>
        public double AreaCalc(params double[] parameterArray)
        {
            if (parameterArray.Length > 1 && parameterArray.Length < 1) // проверяю сколько параметров вписали, если больше или меньше, то ошибка
            {
                throw new Exception("It's can be only one radius");
            }
            return Math.Round(Math.PI * parameterArray[0], 2); // округляю до двух знаков после запятой, мне кажется так лучше
        }
    }
    public class TriangleAreaCalc : CalculateAreaBehavier
    {
        /// <summary>
        /// Площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="parameterArray">Стороны треугольника</param>
        /// <returns></returns>
        public double AreaCalc(params double[] parameterArray)
        {
            if (parameterArray.Length > 3 && parameterArray.Length < 3) // проверяю сколько параметров вписали, если больше или меньше, то ошибка
            {
                throw new Exception("It's can be only three sides");
            }
            double perimetr = 0;
            foreach (double num in parameterArray)
            {
                perimetr += num;
            }
            perimetr /= 2;

            double firstSide = parameterArray[0];
            double secondSide = parameterArray[1];
            double thirdSide = parameterArray[2];

            return Math.Round(AreaBy3SidesAndPerimetrFormula(perimetr, firstSide, secondSide, thirdSide), 2); // округляю до двух знаков после запятой, мне кажется так лучше
        }
        /// <summary>
        /// Метод на проверку является ли треугольник прямоугольным
        /// </summary>
        /// <param name="firstLeg">первый катет</param>
        /// <param name="secondLeg">второй катет</param>
        /// <param name="hypotenuse">гипотенуза</param>
        /// <returns></returns>
        public static bool CheckRightTriangle(double firstLeg, double secondLeg, double hypotenuse)
        {
            if(Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2) == Math.Pow(hypotenuse, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Формула для вычисления площади треугольника зная периметр и все его стороны
        /// </summary>
        /// <param name="perimetr">Периметр треугольника</param>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        /// <returns></returns>
        private double AreaBy3SidesAndPerimetrFormula(double perimetr, double firstSide, double secondSide, double thirdSide)
        {
            return Math.Sqrt(perimetr * (perimetr - firstSide) * (perimetr - secondSide) * (perimetr - thirdSide));
        }
    }
}
