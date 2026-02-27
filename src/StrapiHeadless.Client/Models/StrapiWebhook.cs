using System.Text.Json;

namespace StrapiHeadless.Client.Models;

public class StrapiWebhook
{
    public string Event { get; set; }
    public string Model { get; set; }

    public JsonElement Entry { get; set; }
}