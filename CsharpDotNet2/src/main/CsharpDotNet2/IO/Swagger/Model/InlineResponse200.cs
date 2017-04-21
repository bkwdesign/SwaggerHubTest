using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InlineResponse200 {
    /// <summary>
    /// Gets or Sets FurType
    /// </summary>
    [DataMember(Name="FurType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FurType")]
    public string FurType { get; set; }

    /// <summary>
    /// Gets or Sets LikesBannanas
    /// </summary>
    [DataMember(Name="LikesBannanas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LikesBannanas")]
    public bool? LikesBannanas { get; set; }

    /// <summary>
    /// Gets or Sets LooksScary
    /// </summary>
    [DataMember(Name="LooksScary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LooksScary")]
    public bool? LooksScary { get; set; }

    /// <summary>
    /// Gets or Sets Costume
    /// </summary>
    [DataMember(Name="Costume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Costume")]
    public string Costume { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse200 {\n");
      sb.Append("  FurType: ").Append(FurType).Append("\n");
      sb.Append("  LikesBannanas: ").Append(LikesBannanas).Append("\n");
      sb.Append("  LooksScary: ").Append(LooksScary).Append("\n");
      sb.Append("  Costume: ").Append(Costume).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
