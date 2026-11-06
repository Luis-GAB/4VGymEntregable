using System.Text.Json.Serialization;

namespace _4VGymEntregable.Models {
    public class Instructor {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("photo_url")]
        public string PhotoUrl { get; set; } = string.Empty;

        [JsonPropertyName("phone")]
        public string Phone { get; set; } = string.Empty;

        public ICollection<Activity> Activities { get; set; } = new List<Activity>();

    }
}
