using System;

namespace MapsAPI.Models.Terrain
{
  public class Coordinate
  {
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate(string coord)
    {
      string[] values = coord.Split(',');
      if(values.Length != 2)
      {
        this.X = -1;
        this.Y = -1;
        throw new Exception("Coordinate has improper number of values.");
      }

      this.X = Int32.Parse(values[0]);
      this.Y = Int32.Parse(values[1]);
    }

    public override bool Equals(object obj)
    {
      return Equals((Coordinate)obj);
    }

    public bool Equals(Coordinate c)
    {
      return this.X == c.X
          && this.Y == c.Y;
    }
  }
}