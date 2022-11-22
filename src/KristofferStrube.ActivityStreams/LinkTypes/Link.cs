﻿using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Link : ObjectOrLink, ILink
{
    [JsonPropertyName("href")]
    public Uri? Href { get; set; }
}
