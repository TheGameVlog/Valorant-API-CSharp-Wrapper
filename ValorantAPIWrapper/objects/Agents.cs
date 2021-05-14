using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantAPIWrapper
{
    public class Role
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayIcon")]
        public string DisplayIcon { get; set; }

        [JsonProperty("assetPath")]
        public string AssetPath { get; set; }
    }

    public class Ability
    {
        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayIcon")]
        public string DisplayIcon { get; set; }
    }

    public class Agents
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("developerName")]
        public string DeveloperName { get; set; }

        [JsonProperty("characterTags")]
        public List<string> CharacterTags { get; set; }

        [JsonProperty("displayIcon")]
        public string DisplayIcon { get; set; }

        [JsonProperty("displayIconSmall")]
        public string DisplayIconSmall { get; set; }

        [JsonProperty("bustPortrait")]
        public string BustPortrait { get; set; }

        [JsonProperty("fullPortrait")]
        public string FullPortrait { get; set; }

        [JsonProperty("assetPath")]
        public string AssetPath { get; set; }

        [JsonProperty("isFullPortraitRightFacing")]
        public bool IsFullPortraitRightFacing { get; set; }

        [JsonProperty("isPlayableCharacter")]
        public bool IsPlayableCharacter { get; set; }

        [JsonProperty("isAvailableForTest")]
        public bool IsAvailableForTest { get; set; }

        [JsonProperty("role")]
        public Role Role { get; set; }

        [JsonProperty("abilities")]
        public List<Ability> Abilities { get; set; }
    }

    public class AgentsResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public List<Agents> Data { get; set; }
    }

    public class AgentResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public Agents Data { get; set; }
    }

}
