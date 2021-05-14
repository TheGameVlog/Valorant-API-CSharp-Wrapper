using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantAPIWrapper
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Bundle
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayIcon")]
        public string DisplayIcon { get; set; }

        [JsonProperty("displayIcon2")]
        public string DisplayIcon2 { get; set; }

        [JsonProperty("verticalPromoImage")]
        public string VerticalPromoImage { get; set; }

        [JsonProperty("assetPath")]
        public string AssetPath { get; set; }
    }

    public class AllBundles
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public List<Bundle> Data { get; set; }
    }

    public class SingleBundle
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public Bundle Data { get; set; }
    }


}
