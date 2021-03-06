/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it&#39;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
    /// </summary>
    [DataContract]
    public partial class V1PreferredSchedulingTerm :  IEquatable<V1PreferredSchedulingTerm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PreferredSchedulingTerm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1PreferredSchedulingTerm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PreferredSchedulingTerm" /> class.
        /// </summary>
        /// <param name="Preference">A node selector term, associated with the corresponding weight. (required).</param>
        /// <param name="Weight">Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100. (required).</param>
        public V1PreferredSchedulingTerm(V1NodeSelectorTerm Preference = default(V1NodeSelectorTerm), int? Weight = default(int?))
        {
            // to ensure "Preference" is required (not null)
            if (Preference == null)
            {
                throw new InvalidDataException("Preference is a required property for V1PreferredSchedulingTerm and cannot be null");
            }
            else
            {
                this.Preference = Preference;
            }
            // to ensure "Weight" is required (not null)
            if (Weight == null)
            {
                throw new InvalidDataException("Weight is a required property for V1PreferredSchedulingTerm and cannot be null");
            }
            else
            {
                this.Weight = Weight;
            }
        }
        
        /// <summary>
        /// A node selector term, associated with the corresponding weight.
        /// </summary>
        /// <value>A node selector term, associated with the corresponding weight.</value>
        [DataMember(Name="preference", EmitDefaultValue=false)]
        public V1NodeSelectorTerm Preference { get; set; }

        /// <summary>
        /// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
        /// </summary>
        /// <value>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PreferredSchedulingTerm {\n");
            sb.Append("  Preference: ").Append(Preference).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(obj as V1PreferredSchedulingTerm);
        }

        /// <summary>
        /// Returns true if V1PreferredSchedulingTerm instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PreferredSchedulingTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PreferredSchedulingTerm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Preference == other.Preference ||
                    this.Preference != null &&
                    this.Preference.Equals(other.Preference)
                ) && 
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
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
                if (this.Preference != null)
                    hash = hash * 59 + this.Preference.GetHashCode();
                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
