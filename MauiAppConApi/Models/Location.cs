

namespace MauiAppConApi.Models;

public class Location
{
    public string Name { get; set; }
    public string Url { get; set; }
}


public class LocationComplete
{
    public int Id { get; set; }
    public string ?Name { get; set; }
    public string ?Type { get; set; }
    public string ?Dimension { get; set; }
    public List<string> ?Residents { get; set; }
    public string ?Url { get; set; }
    public DateTime Created { get; set; }
}

public class LocationResults
{
    public Info Info { get; set; }
    public List<LocationComplete> Results { get; set; }
}



