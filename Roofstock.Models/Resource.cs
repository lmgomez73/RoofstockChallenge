using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Resource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }

        [JsonPropertyName("isPublic")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonPropertyName("sizeInByte")]
        public long SizeInByte { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("urlMedium")]
        public string UrlMedium { get; set; }

        [JsonPropertyName("urlSmall")]
        public string UrlSmall { get; set; }

        [JsonPropertyName("textContent")]
        public string TextContent { get; set; }
    }

}