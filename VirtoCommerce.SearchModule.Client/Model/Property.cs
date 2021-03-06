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
    /// Property
    /// </summary>
    [DataContract]
    public partial class Property :  IEquatable<Property>
    {
        /// <summary>
        /// Gets or Sets IsReadOnly
        /// </summary>
        [DataMember(Name="isReadOnly", EmitDefaultValue=false)]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets IsManageable
        /// </summary>
        [DataMember(Name="isManageable", EmitDefaultValue=false)]
        public bool? IsManageable { get; set; }

        /// <summary>
        /// Gets or Sets IsNew
        /// </summary>
        [DataMember(Name="isNew", EmitDefaultValue=false)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CatalogId
        /// </summary>
        [DataMember(Name="catalogId", EmitDefaultValue=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Gets or Sets Catalog
        /// </summary>
        [DataMember(Name="catalog", EmitDefaultValue=false)]
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public Category Category { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or Sets Dictionary
        /// </summary>
        [DataMember(Name="dictionary", EmitDefaultValue=false)]
        public bool? Dictionary { get; set; }

        /// <summary>
        /// Gets or Sets Multivalue
        /// </summary>
        [DataMember(Name="multivalue", EmitDefaultValue=false)]
        public bool? Multivalue { get; set; }

        /// <summary>
        /// Gets or Sets Multilanguage
        /// </summary>
        [DataMember(Name="multilanguage", EmitDefaultValue=false)]
        public bool? Multilanguage { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<PropertyValue> Values { get; set; }

        /// <summary>
        /// Gets or Sets DictionaryValues
        /// </summary>
        [DataMember(Name="dictionaryValues", EmitDefaultValue=false)]
        public List<PropertyDictionaryValue> DictionaryValues { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<PropertyAttribute> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets DisplayNames
        /// </summary>
        [DataMember(Name="displayNames", EmitDefaultValue=false)]
        public List<PropertyDisplayName> DisplayNames { get; set; }

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
            sb.Append("class Property {\n");
            sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
            sb.Append("  IsManageable: ").Append(IsManageable).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CatalogId: ").Append(CatalogId).Append("\n");
            sb.Append("  Catalog: ").Append(Catalog).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Dictionary: ").Append(Dictionary).Append("\n");
            sb.Append("  Multivalue: ").Append(Multivalue).Append("\n");
            sb.Append("  Multilanguage: ").Append(Multilanguage).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  DictionaryValues: ").Append(DictionaryValues).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  DisplayNames: ").Append(DisplayNames).Append("\n");
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
            return this.Equals(obj as Property);
        }

        /// <summary>
        /// Returns true if Property instances are equal
        /// </summary>
        /// <param name="other">Instance of Property to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Property other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsReadOnly == other.IsReadOnly ||
                    this.IsReadOnly != null &&
                    this.IsReadOnly.Equals(other.IsReadOnly)
                ) && 
                (
                    this.IsManageable == other.IsManageable ||
                    this.IsManageable != null &&
                    this.IsManageable.Equals(other.IsManageable)
                ) && 
                (
                    this.IsNew == other.IsNew ||
                    this.IsNew != null &&
                    this.IsNew.Equals(other.IsNew)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CatalogId == other.CatalogId ||
                    this.CatalogId != null &&
                    this.CatalogId.Equals(other.CatalogId)
                ) && 
                (
                    this.Catalog == other.Catalog ||
                    this.Catalog != null &&
                    this.Catalog.Equals(other.Catalog)
                ) && 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Dictionary == other.Dictionary ||
                    this.Dictionary != null &&
                    this.Dictionary.Equals(other.Dictionary)
                ) && 
                (
                    this.Multivalue == other.Multivalue ||
                    this.Multivalue != null &&
                    this.Multivalue.Equals(other.Multivalue)
                ) && 
                (
                    this.Multilanguage == other.Multilanguage ||
                    this.Multilanguage != null &&
                    this.Multilanguage.Equals(other.Multilanguage)
                ) && 
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) && 
                (
                    this.DictionaryValues == other.DictionaryValues ||
                    this.DictionaryValues != null &&
                    this.DictionaryValues.SequenceEqual(other.DictionaryValues)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) && 
                (
                    this.DisplayNames == other.DisplayNames ||
                    this.DisplayNames != null &&
                    this.DisplayNames.SequenceEqual(other.DisplayNames)
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

                if (this.IsReadOnly != null)
                    hash = hash * 59 + this.IsReadOnly.GetHashCode();

                if (this.IsManageable != null)
                    hash = hash * 59 + this.IsManageable.GetHashCode();

                if (this.IsNew != null)
                    hash = hash * 59 + this.IsNew.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.CatalogId != null)
                    hash = hash * 59 + this.CatalogId.GetHashCode();

                if (this.Catalog != null)
                    hash = hash * 59 + this.Catalog.GetHashCode();

                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();

                if (this.Dictionary != null)
                    hash = hash * 59 + this.Dictionary.GetHashCode();

                if (this.Multivalue != null)
                    hash = hash * 59 + this.Multivalue.GetHashCode();

                if (this.Multilanguage != null)
                    hash = hash * 59 + this.Multilanguage.GetHashCode();

                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                if (this.DictionaryValues != null)
                    hash = hash * 59 + this.DictionaryValues.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.DisplayNames != null)
                    hash = hash * 59 + this.DisplayNames.GetHashCode();

                if (this.IsInherited != null)
                    hash = hash * 59 + this.IsInherited.GetHashCode();

                return hash;
            }
        }
    }
}
