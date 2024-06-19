using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdsterraTestTask;

public class Chat
{
    [JsonPropertyName("admin_panel_id")]
    public string AdminPanelId { get; set; }
    
    [JsonPropertyName("chats_last_month")]
    public int ChatsLastMonth { get; set; }

    public static List<Chat> GetChats()
    {
        string json = """
                      [
                      	{
                              "admin_panel_id": "1346",
                              "chats_last_month": 301
                      	},
                          {
                              "admin_panel_id": "1412",
                              "chats_last_month": 331
                      	},
                          {
                              "admin_panel_id": "1235",
                              "chats_last_month": 45
                      	},
                          {
                              "admin_panel_id": "1413",
                              "chats_last_month": 249
                      	},
                          {
                              "admin_panel_id": "1412",
                              "chats_last_month": 4
                      	},
                          {
                              "admin_panel_id": "312",
                              "chats_last_month": 291
                      	}
                      ]
                      """;
        return JsonSerializer.Deserialize<List<Chat>>(json)!;
    }
}