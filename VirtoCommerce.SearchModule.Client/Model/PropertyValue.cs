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
    /// PropertyValue
    /// </summary>
    [DataContract]
    public partial class PropertyValue :  IEquatable<PropertyValue>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name="propertyName", EmitDefaultValue=false)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or Sets PropertyId
        /// </summary>
        [DataMember(Name="propertyId", EmitDefaultValue=false)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or Sets ValueId
        /// </summary>
        [DataMember(Name="valueId", EmitDefaultValue=false)]
        public string ValueId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets IsInherited
        /// </summary>
        [DataMember(Name="isInherited", EmitDefaultValue=false)]
        public bool? IsInherited { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyValue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  ValueId: ").Append(ValueId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  IsInherited: ").Append(IsInherited).Append("\n");
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
            return this.Equals(obj as PropertyValue);
        }

        /// <summary>
        /// Returns true if PropertyValue instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PropertyName == other.PropertyName ||
                    this.PropertyName != null &&
                    this.PropertyName.Equals(other.PropertyName)
                ) && 
                (
                    this.PropertyId == other.PropertyId ||
                    this.PropertyId != null &&
                    this.PropertyId.Equals(other.PropertyId)
                ) && 
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
                ) && 
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
                ) && 
                (
                    this.ValueId == other.ValueId ||
                    this.ValueId != null &&
                    this.ValueId.Equals(other.ValueId)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.IsInherited == other.IsInherited ||
                    this.IsInherited != null &&
                    this.IsInherited.Equals(other.IsInherited)
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

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.PropertyName != null)
                    hash = hash * 59 + this.PropertyName.GetHashCode();

                if (this.PropertyId != null)
                    hash = hash * 59 + this.PropertyId.GetHashCode();

                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();

                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();

                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();

                if (this.ValueId != null)
                    hash = hash * 59 + this.ValueId.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.IsInherited != null)
                    hash = hash * 59 + this.IsInherited.GetHashCode();

                return hash;
            }
        }
    }
}
