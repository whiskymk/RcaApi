﻿/*
 * Reports, certificates and applications API
 *
 * This is API for part of the customer portal, Reports, certificates and applications
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Quipu.RcaApiBase.OpenApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CaseSaveResult : IEquatable<CaseSaveResult>
    {
        /// <summary>
        /// Gets or Sets CaseId
        /// </summary>

        [DataMember(Name = "caseId")]
        public string CaseId { get; set; }

        /// <summary>
        /// Gets or Sets SavedStatus
        /// </summary>

        [DataMember(Name = "savedStatus")]
        public string SavedStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseSaveResult {\n");
            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  SavedStatus: ").Append(SavedStatus).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CaseSaveResult)obj);
        }

        /// <summary>
        /// Returns true if CaseSaveResult instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseSaveResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseSaveResult other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    CaseId == other.CaseId ||
                    CaseId != null &&
                    CaseId.Equals(other.CaseId)
                ) &&
                (
                    SavedStatus == other.SavedStatus ||
                    SavedStatus != null &&
                    SavedStatus.Equals(other.SavedStatus)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (CaseId != null)
                    hashCode = hashCode * 59 + CaseId.GetHashCode();
                if (SavedStatus != null)
                    hashCode = hashCode * 59 + SavedStatus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(CaseSaveResult left, CaseSaveResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CaseSaveResult left, CaseSaveResult right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}