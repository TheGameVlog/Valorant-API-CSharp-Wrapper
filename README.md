# Valorant-API CSharp Wrapper
Simple to use .NET Wrapper to connect to Valorant-API.com

## Getting Started
 ```
            ValorantClient vClient = new ValorantClient();
            List<Agents> allAgents = vClient.GetAgents();
            Console.WriteLine(allAgents[0].DisplayName);
```
## Features
Classes Created for Object Types with Properties which makes fetching data more easier

**Example Agents Class**
```
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
```
## WPF Example
A WPF Example and Console Application Example is included in this Repo.
![](https://github.com/TheGameVlog/Valorant-API-CSharp-Wrapper/blob/master/Screenshot/WPF-Example%20Window.png?raw=true)

## To Do
As of now the wrapper only includes objects for Agents, Buddies, Bundles, Maps, ContentTiers support for more will be added shortly.

## Developed and Maintained By
**The Game Vlog**
<p align="left">
<a href="https://twitter.com/thegamevlog" target="blank"><img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/twitter.svg" alt="thegamevlog" height="30" width="40" /></a>
<a href="https://www.youtube.com/c/thegamevlogcom" target="blank"><img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/youtube.svg" alt="thegamevlogcom" height="30" width="40" /></a>
</p>

# Credits
https://valorant-api.com/

***Riot Games, Valorant, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.***
