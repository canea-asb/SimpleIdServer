﻿using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace SimpleIdServer.Mobile.DTOs;

public class BaseCredentialResult
{
    [JsonPropertyName("format")]
    public string Format { get; set; }
    [JsonPropertyName("credential")]
    public JsonNode Credential { get; set; }
    [JsonPropertyName("c_nonce")]
    public string CNonce { get; set; }
    [JsonPropertyName("c_nonce_expires_in")]
    public string CNonceExpires { get; set; }
}
