using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdsterraTestTask;

public class Status
{
    [JsonPropertyName("status_id")]
    public int Id { get; set; }
    
    [JsonPropertyName("status_name")]
    public string StatusName { get; set; }

    public static List<Status> GetStatuses()
    {
        string json = """
    [

        {
            "status_id": 1,
            "status_name": "hiring"
        },
        {
            "status_id": 2,
            "status_name": "working"
        },
        {
            "status_id": 3,
            "status_name": "fired"
        },
        {
            "status_id": 4,
            "status_name": "vacation"
        }
        ]
    """;
    return JsonSerializer.Deserialize<List<Status>>(json)!;
    }
}