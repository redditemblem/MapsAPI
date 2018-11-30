using MapsAPI.Models.Enums;
using MapsAPI.Models.System;
using MapsAPI.Models.Terrain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MapsAPI.Models
{
  public class Unit
  {
    [JsonProperty("name")]
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public string PortraitURL { get; set; }
    public string Description { get; set; }
    public UnitClass Class { get; set; }
    public Coordinate Coordinates { get; set; }
    public int Experience { get; set; }
    public string Affiliation { get; set; }
    public UnitAlignment Alignment { get; set; }
    public List<string> Tags { get; set; }
    public float CurrentHealth { get; set; }
    public float MaximumHealth { get; set; }
    public float HealthPercentage { get { return (float)Math.Round(CurrentHealth / MaximumHealth, 2); } }
    public int Movement { get; set; }
    public List<Tuple<string, int>> Stats { get; set; }
    public List<Tuple<string, char, int>> WeaponRanks { get; set; }
    public List<Item> Inventory { get; set; }

  }
}