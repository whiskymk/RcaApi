﻿/*
 * Reports, certificates and applications API
 *
 * This is API for part of the customer portal, Reports, certificates and applications
 *
 * OpenAPI spec version: 1.0.1
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
    public partial class Charge : IEquatable<Charge>
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>

        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Three chars currency number UAH EUR etc.
        /// </summary>
        /// <value>Three chars currency number UAH EUR etc.</value>
        [RegularExpression("/[A-Z]{3}/")]
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Charge {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Charge)obj);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="other">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charge other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) &&
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) &&
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
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
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Charge left, Charge right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Charge left, Charge right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
