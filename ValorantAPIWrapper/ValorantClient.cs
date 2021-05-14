using System;
using ValorantAPIWrapper;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;

namespace ValorantAPIWrapper
{
    public class ValorantClient
    {
        const string apiBaseUrl = "https://valorant-api.com/v1/";

        public Agents agents { get; }

        RestClient rstClient;
        

        public ValorantClient()
        {
            //intentionally left blank 
            rstClient = new RestClient();
        }

        public List<Agents> GetAgents(string lang="")
        {
            var request = new RestRequest(apiBaseUrl + "agents", Method.GET);
            if (lang!="")
            {
                request.AddQueryParameter("language", lang);
                
            }

            //return all agents if uuid is not supplied
            var response = rstClient.Execute(request);
              AgentsResponse getAllAgents = JsonConvert.DeserializeObject<AgentsResponse>(response.Content);

            return getAllAgents.Data;            
        }

        public Agents GetAgent(string Uuid,string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "agents", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);
            }

            if (Uuid != "")
            {
                //return agent based on uuid
                request = new RestRequest(apiBaseUrl + "agents/" + Uuid, Method.GET);
                var response = rstClient.Execute(request);
                AgentResponse getSingleAgent  = JsonConvert.DeserializeObject<AgentResponse>(response.Content);
                return getSingleAgent.Data;
            }
            else
            { throw new Exception("You need to specify a UUID or just leave blank"); }

        }

        public List<Buddy> GetBuddies(string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "buddies", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);

            }

            //return all agents if uuid is not supplied
            var response = rstClient.Execute(request);
            AllBuddies getAllBuddies = JsonConvert.DeserializeObject<AllBuddies>(response.Content);

            return getAllBuddies.data;
        }

        public Buddy GetBuddy(string Uuid, string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "agents", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);
            }

            if (Uuid != "")
            {
                //return agent based on uuid
                request = new RestRequest(apiBaseUrl + "agents/" + Uuid, Method.GET);
                var response = rstClient.Execute(request);
                SingleBuddy getSingleBuddy = JsonConvert.DeserializeObject<SingleBuddy>(response.Content);
                return getSingleBuddy.data;
            }
            else
            { throw new Exception("You need to specify a UUID or just leave blank"); }

        }

        public List<Bundle> GetBundles(string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "bundles", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);

            }

            //return all agents if uuid is not supplied
            var response = rstClient.Execute(request);
            AllBundles allBundles = JsonConvert.DeserializeObject<AllBundles>(response.Content);

            return allBundles.Data;
        }

        public Bundle GetBundle(string Uuid, string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "bundles", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);
            }

            if (Uuid != "")
            {
                //return agent based on uuid
                request = new RestRequest(apiBaseUrl + "bundles/" + Uuid, Method.GET);
                var response = rstClient.Execute(request);
                SingleBundle getSingleBundle = JsonConvert.DeserializeObject<SingleBundle>(response.Content);
                return getSingleBundle.Data;
            }
            else
            { throw new Exception("You need to specify a UUID or just leave blank"); }

        }

        public List<Map> GetMaps(string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "maps", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);

            }

            //return all agents if uuid is not supplied
            var response = rstClient.Execute(request);
            AllMaps allMaps = JsonConvert.DeserializeObject<AllMaps>(response.Content);

            return allMaps.Data;
        }

        public Map GetMap(string Uuid, string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "bundles", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);
            }

            if (Uuid != "")
            {
                //return agent based on uuid
                request = new RestRequest(apiBaseUrl + "maps/" + Uuid, Method.GET);
                var response = rstClient.Execute(request);
                SingleMap getSingleMap = JsonConvert.DeserializeObject<SingleMap>(response.Content);
                return getSingleMap.Data;
            }
            else
            { throw new Exception("You need to specify a UUID or just leave blank"); }

        }

        public List<ContentTier> GetContentTiers(string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "contenttiers", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);

            }

            //return all agents if uuid is not supplied
            var response = rstClient.Execute(request);
            AllContentTiers allCT = JsonConvert.DeserializeObject<AllContentTiers>(response.Content);

            return allCT.Data;
        }

        public ContentTier GetContentTier(string Uuid, string lang = "")
        {
            var request = new RestRequest(apiBaseUrl + "contenttiers", Method.GET);
            if (lang != "")
            {
                request.AddQueryParameter("language", lang);
            }

            if (Uuid != "")
            {
                //return agent based on uuid
                request = new RestRequest(apiBaseUrl + "contenttiers/" + Uuid, Method.GET);
                var response = rstClient.Execute(request);
                SingleContentTier getSingleCT = JsonConvert.DeserializeObject<SingleContentTier>(response.Content);
                return getSingleCT.Data;
            }
            else
            { throw new Exception("You need to specify a UUID or just leave blank"); }

        }

    }
}
