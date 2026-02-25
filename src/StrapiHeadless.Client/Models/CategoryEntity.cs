using Newtonsoft.Json;

namespace StrapiHeadless.Client.Models;

public class CategoryEntity
{
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("documentId")]
    public string? DocumentId { get; set; }
}