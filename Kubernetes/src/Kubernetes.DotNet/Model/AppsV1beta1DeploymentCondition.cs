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
    /// DeploymentCondition describes the state of a deployment at a certain point.
    /// </summary>
    [DataContract]
    public partial class AppsV1beta1DeploymentCondition :  IEquatable<AppsV1beta1DeploymentCondition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppsV1beta1DeploymentCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppsV1beta1DeploymentCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppsV1beta1DeploymentCondition" /> class.
        /// </summary>
        /// <param name="LastTransitionTime">Last time the condition transitioned from one status to another..</param>
        /// <param name="LastUpdateTime">The last time this condition was updated..</param>
        /// <param name="Message">A human readable message indicating details about the transition..</param>
        /// <param name="Reason">The reason for the condition&#39;s last transition..</param>
        /// <param name="Status">Status of the condition, one of True, False, Unknown. (required).</param>
        /// <param name="Type">Type of deployment condition. (required).</param>
        public AppsV1beta1DeploymentCondition(DateTime? LastTransitionTime = default(DateTime?), DateTime? LastUpdateTime = default(DateTime?), string Message = default(string), string Reason = default(string), string Status = default(string), string Type = default(string))
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for AppsV1beta1DeploymentCondition and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for AppsV1beta1DeploymentCondition and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.LastTransitionTime = LastTransitionTime;
            this.LastUpdateTime = LastUpdateTime;
            this.Message = Message;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        /// <value>Last time the condition transitioned from one status to another.</value>
        [DataMember(Name="lastTransitionTime", EmitDefaultValue=false)]
        public DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// The last time this condition was updated.
        /// </summary>
        /// <value>The last time this condition was updated.</value>
        [DataMember(Name="lastUpdateTime", EmitDefaultValue=false)]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// A human readable message indicating details about the transition.
        /// </summary>
        /// <value>A human readable message indicating details about the transition.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The reason for the condition&#39;s last transition.
        /// </summary>
        /// <value>The reason for the condition&#39;s last transition.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        /// <value>Status of the condition, one of True, False, Unknown.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Type of deployment condition.
        /// </summary>
        /// <value>Type of deployment condition.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppsV1beta1DeploymentCondition {\n");
            sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as AppsV1beta1DeploymentCondition);
        }

        /// <summary>
        /// Returns true if AppsV1beta1DeploymentCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of AppsV1beta1DeploymentCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppsV1beta1DeploymentCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastTransitionTime == other.LastTransitionTime ||
                    this.LastTransitionTime != null &&
                    this.LastTransitionTime.Equals(other.LastTransitionTime)
                ) && 
                (
                    this.LastUpdateTime == other.LastUpdateTime ||
                    this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.LastTransitionTime != null)
                    hash = hash * 59 + this.LastTransitionTime.GetHashCode();
                if (this.LastUpdateTime != null)
                    hash = hash * 59 + this.LastUpdateTime.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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