﻿using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INOXCanvasPrototype
{
    public class LayoutsSets
    {
        [JsonProperty("Ressource")]
        public string Ressource { get; set; }

        [JsonProperty("Layouts")]
        public List<Layout> Layouts { get; set; }
    }
}
