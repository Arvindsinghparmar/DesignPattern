internal class Program
{
    private static void Main(string[] args)
    {
        var Instance1 = Logger.Instance;
        var Instance2 = Logger.Instance;
        Instance1.Log("Instace is created successfully");
        Instance2.Log("Instance is created ");
    }
}