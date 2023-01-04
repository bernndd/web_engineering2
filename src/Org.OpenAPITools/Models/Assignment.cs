/*
 * Biletado services
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: dh@blaimi.de
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;
using Microsoft.EntityFrameworkCore;

namespace Org.OpenAPITools.Models
{

    /// <summary>
    /// the assignment between an employee and a reservation with its role. An assignment must only exist once per reservation and role. 
    /// </summary>
    [DataContract]
    public partial class Assignment : IEquatable<Assignment>
    {


        /// <summary>
        /// the id of the assignment
        /// </summary>
        /// <value>the id of the assignment</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// the id of the employee this assignment references
        /// </summary>
        /// <value>the id of the employee this assignment references</value>
        [Required]
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// the id of the reservation this assignment references
        /// </summary>
        /// <value>the id of the reservation this assignment references</value>
        [Required]
        [DataMember(Name = "reservation_id", EmitDefaultValue = false)]
        public Guid ReservationId { get; set; }


        /// <summary>
        /// the role which the employee impersonates in this assignment
        /// </summary>
        /// <value>the role which the employee impersonates in this assignment</value>
        [TypeConverter(typeof(CustomEnumConverter<RoleEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum RoleEnum
        {

            /// <summary>
            /// Enum ServiceEnum for service
            /// </summary>
            [EnumMember(Value = "service")]
            ServiceEnum = 1,

            /// <summary>
            /// Enum CleanupEnum for cleanup
            /// </summary>
            [EnumMember(Value = "cleanup")]
            CleanupEnum = 2
        }

        /// <summary>
        /// the role which the employee impersonates in this assignment
        /// </summary>
        /// <value>the role which the employee impersonates in this assignment</value>
        [Required]
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public RoleEnum Role { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Assignment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  ReservationId: ").Append(ReservationId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Assignment)obj);
        }

        /// <summary>
        /// Returns true if Assignment instances are equal
        /// </summary>
        /// <param name="other">Instance of Assignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Assignment other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    EmployeeId == other.EmployeeId ||
                    EmployeeId != null &&
                    EmployeeId.Equals(other.EmployeeId)
                ) &&
                (
                    ReservationId == other.ReservationId ||
                    ReservationId != null &&
                    ReservationId.Equals(other.ReservationId)
                ) &&
                (
                    Role == other.Role ||

                    Role.Equals(other.Role)
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (EmployeeId != null)
                    hashCode = hashCode * 59 + EmployeeId.GetHashCode();
                if (ReservationId != null)
                    hashCode = hashCode * 59 + ReservationId.GetHashCode();

                hashCode = hashCode * 59 + Role.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Assignment left, Assignment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Assignment left, Assignment right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
