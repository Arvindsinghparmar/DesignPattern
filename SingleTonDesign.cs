public sealed class Logger
{
    private Logger() { }
    private static Logger _logger = null;
    private static readonly object _lock = new object();
    public static Logger Instance
    {
        get
        {
            if (_logger != null)
            {
                System.Console.WriteLine("Already Created instance");
            }
            if (_logger == null)
                {
                    lock (_lock)
                    {
                        if (_logger == null)
                        {
                            _logger = new Logger();
                            System.Console.WriteLine("Intance created");
                        }
                    }
                }
            return _logger;
        }
    }
    public void Log(string message)
    {
        System.Console.WriteLine($"Log:{message}");
    }
}