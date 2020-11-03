using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ipdb
{
    /**
     * @copyright IPIP.net
     */
    public class MetaData
    {
        [JsonPropertyName("build")] public int Build { get; set; }
        [JsonPropertyName("ip_version")] public int IPVersion { get; set; }
        [JsonPropertyName("node_count")] public int NodeCount { get; set; }
        [JsonPropertyName("languages")] public Dictionary<string, int> Languages { get; set; }
        [JsonPropertyName("fields")] public string[] Fields { get; set; }
        [JsonPropertyName("total_size")] public int TotalSize { get; set; }
    }
}
