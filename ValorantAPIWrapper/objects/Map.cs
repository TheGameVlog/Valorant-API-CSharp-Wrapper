using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantAPIWrapper
{
    public class Map
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("displayIcon")]
        public string DisplayIcon { get; set; }

        [JsonProperty("listViewIcon")]
        public string ListViewIcon { get; set; }

        [JsonProperty("splash")]
        public string Splash { get; set; }

        [JsonProperty("assetPath")]
        public string AssetPath { get; set; }

        [JsonProperty("mapUrl")]
        public string MapUrl { get; set; }

        [JsonProperty("xMultiplier")]
        public double XMultiplier { get; set; }

        [JsonProperty("yMultiplier")]
        public double YMultiplier { get; set; }

        [JsonProperty("xScalarToAdd")]
        public double XScalarToAdd { get; set; }

        [JsonProperty("yScalarToAdd")]
        public double YScalarToAdd { get; set; }
    }

    public class AllMaps
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public List<Map> Data { get; set; }
    }

    public class SingleMap
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public Map Data { get; set; }
    }


}
