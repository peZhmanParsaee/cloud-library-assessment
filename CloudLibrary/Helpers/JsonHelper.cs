using System.Text.Json;

namespace CloudLibrary.Helpers {
  public static class JsonHelper {
    public static string SerializeResouceContents(object data) {
      var options = new JsonSerializerOptions() {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
      };
      var jsonString = JsonSerializer.Serialize(data, options);
      return jsonString;
    }
  }
}
