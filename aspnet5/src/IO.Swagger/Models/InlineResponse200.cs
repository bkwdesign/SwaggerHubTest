/*
 * Sample Application Flow OAuth2 Project
 *
 * This is an example of using OAuth2 Application Flow in a specification to describe security to your API.
 *
 * OpenAPI spec version: 0.0.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse200 :  IEquatable<InlineResponse200>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        /// <param name="FurType">FurType.</param>
        /// <param name="LikesBannanas">LikesBannanas.</param>
        /// <param name="LooksScary">LooksScary.</param>
        /// <param name="Costume">Costume.</param>
        public InlineResponse200(string FurType = null, bool? LikesBannanas = null, bool? LooksScary = null, string Costume = null)
        {
            this.FurType = FurType;
            this.LikesBannanas = LikesBannanas;
            this.LooksScary = LooksScary;
            this.Costume = Costume;
            
        }

        /// <summary>
        /// Gets or Sets FurType
        /// </summary>
        [DataMember(Name="FurType")]
        public string FurType { get; set; }

        /// <summary>
        /// Gets or Sets LikesBannanas
        /// </summary>
        [DataMember(Name="LikesBannanas")]
        public bool? LikesBannanas { get; set; }

        /// <summary>
        /// Gets or Sets LooksScary
        /// </summary>
        [DataMember(Name="LooksScary")]
        public bool? LooksScary { get; set; }

        /// <summary>
        /// Gets or Sets Costume
        /// </summary>
        [DataMember(Name="Costume")]
        public string Costume { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((InlineResponse200)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.FurType == other.FurType ||
                    this.FurType != null &&
                    this.FurType.Equals(other.FurType)
                ) && 
                (
                    this.LikesBannanas == other.LikesBannanas ||
                    this.LikesBannanas != null &&
                    this.LikesBannanas.Equals(other.LikesBannanas)
                ) && 
                (
                    this.LooksScary == other.LooksScary ||
                    this.LooksScary != null &&
                    this.LooksScary.Equals(other.LooksScary)
                ) && 
                (
                    this.Costume == other.Costume ||
                    this.Costume != null &&
                    this.Costume.Equals(other.Costume)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.FurType != null)
                    hash = hash * 59 + this.FurType.GetHashCode();
                    if (this.LikesBannanas != null)
                    hash = hash * 59 + this.LikesBannanas.GetHashCode();
                    if (this.LooksScary != null)
                    hash = hash * 59 + this.LooksScary.GetHashCode();
                    if (this.Costume != null)
                    hash = hash * 59 + this.Costume.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(InlineResponse200 left, InlineResponse200 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse200 left, InlineResponse200 right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
