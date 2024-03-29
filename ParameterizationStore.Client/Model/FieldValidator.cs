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
    /// FieldValidator
    /// </summary>
    [DataContract]
        public partial class FieldValidator :  IEquatable<FieldValidator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValidator" /> class.
        /// </summary>
        /// <param name="validatorEngine">validatorEngine.</param>
        /// <param name="validatorType">validatorType.</param>
        /// <param name="validatorText">validatorText.</param>
        /// <param name="message">message.</param>
        /// <param name="description">description.</param>
        public FieldValidator(ValidatorEngineEnum validatorEngine = default(ValidatorEngineEnum), ValidatorTypeEnum validatorType = default(ValidatorTypeEnum), string validatorText = default(string), string message = default(string), string description = default(string))
        {
            this.ValidatorEngine = validatorEngine;
            this.ValidatorType = validatorType;
            this.ValidatorText = validatorText;
            this.Message = message;
            this.Description = description;
        }
        
        /// <summary>
        /// Gets or Sets ValidatorEngine
        /// </summary>
        [DataMember(Name="validatorEngine", EmitDefaultValue=false)]
        public ValidatorEngineEnum ValidatorEngine { get; set; }

        /// <summary>
        /// Gets or Sets ValidatorType
        /// </summary>
        [DataMember(Name="validatorType", EmitDefaultValue=false)]
        public ValidatorTypeEnum ValidatorType { get; set; }

        /// <summary>
        /// Gets or Sets ValidatorText
        /// </summary>
        [DataMember(Name="validatorText", EmitDefaultValue=false)]
        public string ValidatorText { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

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
            sb.Append("class FieldValidator {\n");
            sb.Append("  ValidatorEngine: ").Append(ValidatorEngine).Append("\n");
            sb.Append("  ValidatorType: ").Append(ValidatorType).Append("\n");
            sb.Append("  ValidatorText: ").Append(ValidatorText).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as FieldValidator);
        }

        /// <summary>
        /// Returns true if FieldValidator instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValidator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValidator input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidatorEngine == input.ValidatorEngine ||
                    (this.ValidatorEngine != null &&
                    this.ValidatorEngine.Equals(input.ValidatorEngine))
                ) && 
                (
                    this.ValidatorType == input.ValidatorType ||
                    (this.ValidatorType != null &&
                    this.ValidatorType.Equals(input.ValidatorType))
                ) && 
                (
                    this.ValidatorText == input.ValidatorText ||
                    (this.ValidatorText != null &&
                    this.ValidatorText.Equals(input.ValidatorText))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.ValidatorEngine != null)
                    hashCode = hashCode * 59 + this.ValidatorEngine.GetHashCode();
                if (this.ValidatorType != null)
                    hashCode = hashCode * 59 + this.ValidatorType.GetHashCode();
                if (this.ValidatorText != null)
                    hashCode = hashCode * 59 + this.ValidatorText.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
