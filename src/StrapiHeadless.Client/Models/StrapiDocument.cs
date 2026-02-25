using Newtonsoft.Json;

namespace StrapiHeadless.Client.Models;

public class StrapiDocument
{
    [JsonProperty("data")]
    public DocumentData Data { get; set; }
    
    public class DocumentData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}