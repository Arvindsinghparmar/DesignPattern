namespace DesignPattern.FactoryDesign
{
    public static class ShapeFactory
    {
        public static IShape Getshape(string type)
        {
            return type.ToLower() switch
            {
                "circle" => new Circle(),
                "square" => new Square(),
                _ => throw new ArgumentException("Invalid Shape")
            };
        }
    }
}