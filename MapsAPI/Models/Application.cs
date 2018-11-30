using System.Collections.Generic;

namespace MapsAPI.Models
{
  public class Application
  {
    public string Title { get; set; }
    public string LogoURL { get; set; }
    public string BackgroundTileURL { get; set; }
    public string PrimaryColor { get; set; }
    public string SecondaryColor { get; set; }
    List<Unit> Units { get; set; }
  }
}
