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
    /// Local represents directly-attached storage with node affinity
    /// </summary>
    [DataContract]
    public partial class V1LocalVolumeSource :  IEquatable<V1LocalVolumeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LocalVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1LocalVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LocalVolumeSource" /> class.
        /// </summary>
        /// <param name="Path">The full path to the volume on the node For alpha, this path must be a directory Once block as a source is supported, then this path can point to a block device (required).</param>
        public V1LocalVolumeSource(string Path = default(string))
        {
            // to ensure "Path" is required (not null)
            if (Path == null)
            {
                throw new InvalidDataException("Path is a required property for V1LocalVolumeSource and cannot be null");
            }
            else
            {
                this.Path = Path;
            }
        }
        
        /// <summary>
        /// The full path to the volume on the node For alpha, this path must be a directory Once block as a source is supported, then this path can point to a block device
        /// </summary>
        /// <value>The full path to the volume on the node For alpha, this path must be a directory Once block as a source is supported, then this path can point to a block device</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1LocalVolumeSource {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(obj as V1LocalVolumeSource);
        }

        /// <summary>
        /// Returns true if V1LocalVolumeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1LocalVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1LocalVolumeSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
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