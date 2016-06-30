using System.Collections.Generic;

namespace CD.Objects
{
  public class Cd
  {
    private static List<Cd> _instances = new List<Cd> {};
    private string _name;
    private int _id;
    private List<Artist> _artists;

    public Cd(string CdName)
    {
      _name = CdName;
      _instances.Add(this);
      _id = _instances.Count;
      _artists = new List<Artist>{};
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Artist> GetArtists()
    {
      return _artists;
    }
    public void AddArtist(Artist artist)
    {
      _artists.Add(artist);
    }
    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Cd Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
