namespace INOXCanvasPrototype.Models
{
    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    public class Layout
    {
        [JsonProperty("LayoutID")]
        public int LayoutID { get; set; }
        [JsonProperty("RessourceType")]
        public string RessourceType { get; set; }
        [JsonProperty("WidthUnits")]
        public int WidthUnits { get; set; }
        [JsonProperty("LengthUnits")]
        public int LengthUnits { get; set; }
        [JsonProperty("Height")]
        public int Height { get; set; }
        [JsonProperty("Cassettes")]
        public List<PlacementGrid_Cassette> Cassettes { get; set; }

        public bool? isNotEmpty { get; set; } = true;

        public int getMaxID()
        {
            return Cassettes.Max(x => x.ID);
        }
    }
}
