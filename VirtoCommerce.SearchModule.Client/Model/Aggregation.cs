using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VirtoCommerce.SearchModule.Client.Model
{
    /// <summary>
    /// Aggregation
    /// </summary>
    [DataContract]
    public partial class Aggregation :  IEquatable<Aggregation>
    {
        /// <summary>
        /// Gets or Sets AggregationType
        /// </summary>
        [DataMember(Name="aggregationType", EmitDefaultValue=false)]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<AggregationLabel> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<AggregationItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Aggregation {\n");
            sb.Append("  AggregationType: ").Append(AggregationType).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Aggregation);
        }

        /// <summary>
        /// Returns true if Aggregation instances are equal
        /// </summary>
        /// <param name="other">Instance of Aggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Aggregation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AggregationType == other.AggregationType ||
                    this.AggregationType != null &&
                    this.AggregationType.Equals(other.AggregationType)
                ) && 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(other.Labels)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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

                if (this.AggregationType != null)
                    hash = hash * 59 + this.AggregationType.GetHashCode();

                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();

                if (this.Labels != null)
                    hash = hash * 59 + this.Labels.GetHashCode();

                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                return hash;
            }
        }
    }
}
