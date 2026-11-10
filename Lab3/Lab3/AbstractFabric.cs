namespace Lab3;

interface IPen
{
    void Notify();
}

interface IPencil
{
    void Notify();
}

class BluePen : IPen
{
    public void Notify()
    {
        Console.WriteLine("В пенале теперь синяя ручка.");
    }
}

class BluePencil : IPencil
{
    public void Notify()
    {
        Console.WriteLine("В пенале теперь синий карандаш.");
    }
}

class BlackPen : IPen
{
    public void Notify()
    {
        Console.WriteLine("В пенале теперь черная ручка.");
    }
}

class BlackPencil : IPencil
{
    public void Notify()
    {
        Console.WriteLine("В пенале теперь черный карандаш.");
    }
}

interface IFactory
{
    IPen CreatePen();
    IPencil CreatePencil();
}

class BlueFactory : IFactory
{
    public IPen CreatePen()
    {
        return new BluePen();
    }

    public IPencil CreatePencil()
    {
        return new BluePencil();
    }
}

class BlackFactory : IFactory
{
    public IPen CreatePen()
    {
        return new BlackPen();
    }

    public IPencil CreatePencil()
    {
        return new BlackPencil();
    }
}

class PencilCase
{
    private IPen _pen;
    private IPencil _pencil;

    public PencilCase(IFactory factory)
    {
        _pen = factory.CreatePen();
        _pencil = factory.CreatePencil();
    }
    
    public void Notify()
    {
        _pen.Notify();
        _pencil.Notify();
    }
}