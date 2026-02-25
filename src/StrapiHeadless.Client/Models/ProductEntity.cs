using Newtonsoft.Json;

namespace StrapiHeadless.Client.Models;

public class ProductEntity
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("documentId")]
    public string? DocumentId { get; set; }

    [JsonProperty("title")]
    public required string Title { get; set; }

    [JsonProperty("description")]
    public required string Description { get; set; }

    [JsonProperty("price")]
    public decimal Price { get; set; }

    [JsonProperty("createdAt")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("updatedAt")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonProperty("publishedAt")]
    public DateTimeOffset? PublishedAt { get; set; }

    [JsonProperty("brand")]
    public string? Brand { get; set; }

    [JsonProperty("category")]
    public CategoryEntity Category { get; set; }
}