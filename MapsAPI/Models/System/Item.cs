namespace MapsAPI.Models.System
{
  public class Item
  {
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public string WeaponType { get; set; }
    public char Rank { get; set; }
    public string UtilizedStat { get; set; }
    public int Uses { get; set; }
    public int Might { get; set; }
    public int Hit { get; set; }
    public int Crit { get; set; }
    public double CritModifier { get; set; }
    public int Avoid { get; set; }
    public int Evade { get; set; }
    public int MinimumRange { get; set; }
    public int MaximumRange { get; set; }
    public string Description { get; set; }
  }
}