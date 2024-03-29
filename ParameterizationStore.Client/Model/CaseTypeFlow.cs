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
    /// CaseTypeFlow
    /// </summary>
    [DataContract]
        public partial class CaseTypeFlow :  IEquatable<CaseTypeFlow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseTypeFlow" /> class.
        /// </summary>
        /// <param name="operationType">operationType.</param>
        /// <param name="id">id.</param>
        /// <param name="caseTypeCode">caseTypeCode.</param>
        /// <param name="smDefinitionCode">smDefinitionCode.</param>
        public CaseTypeFlow(OperationTypeEnum operationType = default(OperationTypeEnum), int? id = default(int?), string caseTypeCode = default(string), string smDefinitionCode = default(string))
        {
            this.OperationType = operationType;
            this.Id = id;
            this.CaseTypeCode = caseTypeCode;
            this.SmDefinitionCode = smDefinitionCode;
        }
        
        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        [DataMember(Name="operationType", EmitDefaultValue=false)]
        public OperationTypeEnum OperationType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets CaseTypeCode
        /// </summary>
        [DataMember(Name="caseTypeCode", EmitDefaultValue=false)]
        public string CaseTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets SmDefinitionCode
        /// </summary>
        [DataMember(Name="smDefinitionCode", EmitDefaultValue=false)]
        public string SmDefinitionCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseTypeFlow {\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CaseTypeCode: ").Append(CaseTypeCode).Append("\n");
            sb.Append("  SmDefinitionCode: ").Append(SmDefinitionCode).Append("\n");
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
            return this.Equals(input as CaseTypeFlow);
        }

        /// <summary>
        /// Returns true if CaseTypeFlow instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseTypeFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseTypeFlow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CaseTypeCode == input.CaseTypeCode ||
                    (this.CaseTypeCode != null &&
                    this.CaseTypeCode.Equals(input.CaseTypeCode))
                ) && 
                (
                    this.SmDefinitionCode == input.SmDefinitionCode ||
                    (this.SmDefinitionCode != null &&
                    this.SmDefinitionCode.Equals(input.SmDefinitionCode))
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
                if (this.OperationType != null)
                    hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CaseTypeCode != null)
                    hashCode = hashCode * 59 + this.CaseTypeCode.GetHashCode();
                if (this.SmDefinitionCode != null)
                    hashCode = hashCode * 59 + this.SmDefinitionCode.GetHashCode();
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
