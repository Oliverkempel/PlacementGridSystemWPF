namespace INOXCanvasPrototype
{
    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cassette
    {
        [JsonProperty("ID")]
        public int ID { get; set; }
        [JsonProperty("startX")]
        public int startX { get; set; }
        [JsonProperty("startY")]
        public int startY { get; set; }
        [JsonProperty("Width")]
        public int Width { get; set; }
        [JsonProperty("Height")]
        public int Height { get; set; }

    }
}
