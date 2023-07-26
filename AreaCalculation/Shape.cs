namespace AreaCalculation
{
    public abstract class Shape
    {
        public CalculateAreaBehavier calculateAreaBehavier;

        public Shape() { }

        public void SetCalculateAreaBehavier(CalculateAreaBehavier cab)
        {
            calculateAreaBehavier = cab;
        }

        public double calcArea(params double[] parameterArray)
        {
            return calculateAreaBehavier.AreaCalc(parameterArray);
        }
    }

    public class Circle : Shape
    {
        public Circle()
        {
            calculateAreaBehavier = new CircleAreaCalc();
        }
    }

    public class Triangle : Shape
    {
        public Triangle()
        {
            calculateAreaBehavier = new TriangleAreaCalc();
        }
    }
}