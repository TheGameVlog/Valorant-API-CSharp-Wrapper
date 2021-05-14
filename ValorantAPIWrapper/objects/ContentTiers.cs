using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantAPIWrapper
{

    public class ContentTier
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("devName")]
        public string DevName { get; set; }

        [JsonProperty("highlightColor")]
        public string HighlightColor { get; set; }

        [JsonProperty("displayIcon")]
        public string DisplayIcon { get; set; }

        [JsonProperty("assetPath")]
        public string AssetPath { get; set; }
    }

    public class AllContentTiers
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public List<ContentTier> Data { get; set; }
    }

    public class SingleContentTier
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public ContentTier Data { get; set; }
    }


}
