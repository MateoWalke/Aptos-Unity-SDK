using Newtonsoft.Json;

namespace Aptos.Unity.Rest.Model
{
    /// <summary>
    /// Represents a Table Item Request
    /// </summary>
    [JsonObject]
    public class TableItemRequest
    {
        [JsonProperty("key_type", Required = Required.Always)]
        public string KeyType { get; set; }

        [JsonProperty("value_type", Required = Required.Always)]
        public string ValueType { get; set; }

        [JsonProperty("key", Required = Required.Always)]
        public string Key { get; set; }
    }
}