using System.Text.Json.Serialization;

namespace Abhishek.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
      
       Employee,
       Student
    }
}
