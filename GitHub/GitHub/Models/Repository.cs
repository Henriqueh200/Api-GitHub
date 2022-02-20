using Newtonsoft.Json;

namespace GitHubProject.Models
{
    public class Repository
    {

        [JsonProperty("id")]

        public string Id { get; set; }


        [JsonProperty("name")]

        public string Name { get; set; }

        [JsonProperty("full_name")]

        public string FullName { get; set; }

        [JsonProperty("created_at")]

        public string CreatedAt { get; set; }

        [JsonProperty("language")]

        public string Language { get; set; }
    }
}
