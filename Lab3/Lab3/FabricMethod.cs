namespace Lab3;

interface ICountry
{
    void Message(string message); 
}

class China : ICountry
{
    public void Message(string message)
    {
        Console.WriteLine($"Сообщение: {message}. Вы пишите человеку, " +
                          $"у которого часовой пояс GMT+8" );
    }
}

class Korea : ICountry
{
    public void Message(string message)
    {
        Console.WriteLine($"Сообщение: {message}. Вы пишите человеку, " +
                          $"у которого часовой пояс GMT+9" );
    }
}

abstract class TimeZoneFactory
{
    public abstract ICountry CreateCountry();

    public void TimeZoneMessage(string message)
    {
        ICountry country = CreateCountry();
        country.Message(message);
    }
}

class ChinaTimeZoneFactory : TimeZoneFactory
{
    public override ICountry CreateCountry()
    {
        return new China();
    }
}

class KoreaTimeZoneFactory : TimeZoneFactory
{
    public override ICountry CreateCountry()
    {
        return new Korea();
    }
}