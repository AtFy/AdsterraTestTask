using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdsterraTestTask;

public class Manager
{
     [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("admin_panel_id")]
    public int? AdminPanelId { get; set; }
    
    [JsonPropertyName("crm_name")]
    public string CrmName { get; set; }
    
    [JsonPropertyName("status")]
    public int Status { get; set; }

    public static List<Manager> GetManagers()
    {
        string json = """
                      [
                      	{
                              "name": "John A",
                              "admin_panel_id": 1346,
                              "crm_name": "j.angerson",
                              "status": 2
                      	},
                          {
                              "name": "Nolan J",
                              "admin_panel_id": 1235,
                              "crm_name": "n.joven",
                              "status": 3
                      	},
                          {
                              "name": "Alex M",
                              "admin_panel_id": null,
                              "crm_name": "",
                              "status": 1
                      	},
                          {
                              "name": "Anna X",
                              "admin_panel_id": 1413,
                              "crm_name": "A.XAVIER",
                              "status": 2
                      	},
                          {
                              "name": "Tanya S",
                              "admin_panel_id": 1412,
                              "crm_name": "t.sizipova",
                              "status": 4
                      	},
                          {
                              "name": "Anton F",
                              "admin_panel_id": null,
                              "crm_name": "",
                              "status": 4
                      	}
                      ]
                      """;
        return JsonSerializer.Deserialize<List<Manager>>(json)!;
    }
}