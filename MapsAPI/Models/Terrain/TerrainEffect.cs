using MapsAPI.Models.Enums;
using System;
using System.Collections.Generic;

namespace MapsAPI.Models.Terrain
{
  public class TerrainEffect
  {
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public int Size { get; set; }
    public SpriteAlignment Alignment { get; set; }
    public List<Tuple<string, ModifierType, float>> Modifiers { get; set; }
  }
}
