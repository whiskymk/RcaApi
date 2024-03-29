/* 
 * ParameterizationStore
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = ParameterizationStore.Client.Client.SwaggerDateConverter;

namespace ParameterizationStore.Client.Model
{
    /// <summary>
    /// ReferenceValue
    /// </summary>
    [DataContract]
        public partial class ReferenceValue :  IEquatable<ReferenceValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceValue" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="extCode">extCode.</param>
        /// <param name="refValue">refValue.</param>
        /// <param name="description">description.</param>
        public ReferenceValue(string id = default(string), string code = default(string), string extCode = default(string), object refValue = default(object), string description = default(string))
        {
            this.Id = id;
            this.Code = code;
            this.ExtCode = extCode;
            this.RefValue = refValue;
            this.Description = description;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets ExtCode
        /// </summary>
        [DataMember(Name="extCode", EmitDefaultValue=false)]
        public string ExtCode { get; set; }

        /// <summary>
        /// Gets or Sets RefValue
        /// </summary>
        [DataMember(Name="refValue", EmitDefaultValue=false)]
        public object RefValue { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferenceValue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ExtCode: ").Append(ExtCode).Append("\n");
            sb.Append("  RefValue: ").Append(RefValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReferenceValue);
        }

        /// <summary>
        /// Returns true if ReferenceValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferenceValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferenceValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ExtCode == input.ExtCode ||
                    (this.ExtCode != null &&
                    this.ExtCode.Equals(input.ExtCode))
                ) && 
                (
                    this.RefValue == input.RefValue ||
                    (this.RefValue != null &&
                    this.RefValue.Equals(input.RefValue))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ExtCode != null)
                    hashCode = hashCode * 59 + this.ExtCode.GetHashCode();
                if (this.RefValue != null)
                    hashCode = hashCode * 59 + this.RefValue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
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
