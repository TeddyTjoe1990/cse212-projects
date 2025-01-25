using System.Collections.Generic;
using System.Text.Json.Serialization;


public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    [JsonPropertyName("features")]
     public List<FeaturesList> Features { get; set; }

}


public class FeaturesList
{
    [JsonPropertyName("properties")]
    public Propertie Properties { get; set; }
}

public class Propertie
{
    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("mag")]
    public double Mag { get; set; }

}



