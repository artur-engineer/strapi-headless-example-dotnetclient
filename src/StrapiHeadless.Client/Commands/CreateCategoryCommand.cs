using Newtonsoft.Json;

namespace StrapiHeadless.Client.Commands;

public class CreateCategoryCommand
{
    [JsonProperty("data")] public CategoryData Data { get; set; }

    public class CategoryData
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}