using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdsterraTestTask;

public class Chat
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("admin_panel_id")]
    public string AdminPanelId { get; set; }
    
    [JsonPropertyName("chats_last_month")]
    public int ChatsLastMonth { get; set; }

    public static List<Chat> GetChats()
    {
        string json = """
                      [
                      	{
                              "name": "j.angerson",
                              "admin_panel_id": "",
                              "chats_last_month": 301
                      	},
                          {
                              "name": "premium support",
                              "admin_panel_id": "1412",
                              "chats_last_month": 331
                      	},
                          {
                              "name": "a.xavier",
                              "admin_panel_id": "",
                              "chats_last_month": 45
                      	},
                          {
                              "name": "A.XAVIER",
                              "admin_panel_id": "",
                              "chats_last_month": 249
                      	},
                          {
                              "name": "n.joven",
                              "admin_panel_id": "1235",
                              "chats_last_month": 4
                      	},
                          {
                              "name": "j.añejo",
                              "admin_panel_id": "512",
                              "chats_last_month": 291
                      	}
                      ]
                      """;
        return JsonSerializer.Deserialize<List<Chat>>(json)!;
    }
}