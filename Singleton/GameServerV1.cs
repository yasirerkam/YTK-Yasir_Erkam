// Kullanma! Kötü kod.
public sealed class GameServer
{
    private static GameServer instance = null;

    private GameServer()
    {
    }

    public static GameServer Instance
    {
        get
        {
            if (instance == null) // <1>
            {
                instance = new GameServer();
            }
            return instance;
        }
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