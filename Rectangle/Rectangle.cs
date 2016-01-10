namespace Rectangle
{
    class Rectangle
    {
        private double Side1;
        private double Side2;

        private double area;
        public double Area
        {
            get { return area; }
        }

        private double perimeter;
        public double Perimeter
        {
            get { return perimeter; }
        }
        
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }


        public double AreaCalculator()
        {
            return area = Side1 * Side2;
        }


        public double PerimeterCalculator()
        {
            return perimeter = Side1 * 2 + Side2 * 2;
        }
    }
}
