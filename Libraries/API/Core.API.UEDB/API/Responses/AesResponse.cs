using Newtonsoft.Json;

using Core.Resources.Framework.CUEParse;

namespace Core.API.UEDB.API.Responses;

public class AesResponse
{
    [JsonProperty("mainKey")] public string MainKey = null!;
    [JsonProperty("dynamicKeys")] public List<EncryptionKey> DynamicKeys = null!;
}
