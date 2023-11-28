internal class Program
{
    private static void Main(string[] args)
    {
        var monitor = new TemperatureMonitor();
        monitor.OnHighTemperature += Monitor_OnHighTemperature;
        monitor.OnLowTemperature += Monitor_OnLowTemperature;

        monitor.IncreaseTemperature(100);
        monitor.DecreaseTemperature(150);
    }
    private static void Monitor_OnHighTemperature()
    {
        Console.WriteLine($"High Temperature Alert! Temperature has exceeded {TemperatureMonitor.HighTemp}°C.");
    }

    private static void Monitor_OnLowTemperature()
    {
        Console.WriteLine($"Low Temperature Alert! Temperature has dropped below {TemperatureMonitor.LowTemp}°C.");
    }
}

public delegate void HighTemp();
public delegate void LowTemp();

public class TemperatureMonitor
{
    public const int LowTemp = -40;
    public const int HighTemp = 40;

    private int _currentTemperature = 0;

    public event HighTemp OnHighTemperature;
    public event LowTemp OnLowTemperature;

    public void IncreaseTemperature(int temp)
    {
        _currentTemperature += temp;
        Console.WriteLine($"Temperature now: {_currentTemperature}°C");
        if (_currentTemperature > HighTemp)
        {
            OnHighTemperature();
        }
    }
    public void DecreaseTemperature(int temp)
    {
        _currentTemperature -= temp;
        Console.WriteLine($"Temperature now: {_currentTemperature}°C");
        if (_currentTemperature < LowTemp)
        {
            OnLowTemperature();
        }
    }
}