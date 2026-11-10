namespace Lab3;

public class Mp3Player
{
    private static Mp3Player _instance;
    
    public string BgColor { get; set; }
    public string Capacity { get; set; }
    
    private Mp3Player()
    {
        BgColor = "Blue";
        Capacity = "4 GB";
    }

    public static Mp3Player Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Mp3Player();
            }
            
            return _instance;
        }
    }
}