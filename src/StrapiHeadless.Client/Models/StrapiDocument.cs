using Newtonsoft.Json;

namespace StrapiHeadless.Client.Models;

public class StrapiDocument
{
    [JsonProperty("data")] public DocumentData Data { get; set; }

    public class DocumentData
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("documentId")] public string DocumentId { get; set; }
        
    }
}

public class StrapiDocument<T>
    where T : class
{
    [JsonProperty("data")] public T Data { get; set; }
}