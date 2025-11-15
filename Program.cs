using DesignPattern.FactoryDesign;

internal class Program
{
    private static void Main(string[] args)
    {
        //This is for SingleTon Design Pattern
        var Instance1 = Logger.Instance;
        var Instance2 = Logger.Instance;
        Instance1.Log("Instace is created successfully");
        Instance2.Log("Instance is created ");

        //This is fpr Factory Design Pattern
        var circleshape= ShapeFactory.Getshape("Circle");
        circleshape.Draw();
        var squareshape= ShapeFactory.Getshape("square");
        squareshape.Draw();
    }
}