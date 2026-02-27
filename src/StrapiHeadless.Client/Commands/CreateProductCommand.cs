using Newtonsoft.Json;

namespace StrapiHeadless.Client.Commands;

public class CreateProductCommand
{
    [JsonProperty("data")]
    public ProductData Data { get; set; }

    public class ProductData
    {
        [JsonProperty("title")]
        public required string Title { get; set; }

        [JsonProperty("description")]
        public required string Description { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("brand")]
        public string? Brand { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    } 
}