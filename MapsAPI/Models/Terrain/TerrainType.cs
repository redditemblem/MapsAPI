using MapsAPI.Models.Enums;
using System;
using System.Collections.Generic;

namespace MapsAPI.Models.Terrain
{
  public class TerrainType
  {
    public string Name { get; set; }
    public ModifierType ModifierType { get; set; }
    public float Avoid { get; set; }
    public float Damage { get; set; }
    public float Health { get; set; }
    public List<Tuple<string, float>> MovementCategories { get; set; }
    public bool BlocksAttacks { get; set; }
  }
}