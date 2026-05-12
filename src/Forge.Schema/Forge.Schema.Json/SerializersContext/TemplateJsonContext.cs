namespace Forge.Schema.Json.SerializersContext;

using System.Text.Json.Serialization;

//TODO: replace with Forge.Schema nuget package
[JsonSerializable(typeof(string))]
[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    WriteIndented = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    UseStringEnumConverter = true,
    UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow)]
public sealed partial class TemplateJsonContext : JsonSerializerContext {}