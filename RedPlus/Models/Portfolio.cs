using System.Text.Json;
using System.Text.Json.Serialization;

namespace RedPlus.Models
{
    public class Portfolio
    {
        /*
         * 모델 클래서 모트 폴리오
         */
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        
        [JsonPropertyName("img")]
        public string Image {  get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Portfolio>(this);
        }
    }
}
