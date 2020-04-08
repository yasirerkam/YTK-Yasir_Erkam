public sealed class Singleton
{
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton()); // <1>

    public static Singleton Instance
    {
        get { return lazy.Value; }
    }

    private Singleton()
    {
    }

    Connection Connect()
    {
        // Method budy
    }

    bool Quit()
    {
        // Method budy
    }
}