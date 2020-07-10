/*
 * Inventory API v2
 *
 * Inventory API for the Cloud Native Workshop
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Coolstore.Inventory.Models
{ 
    /// <summary>
    /// The root of the InventoryItem type&#39;s schema.
    /// </summary>
    [DataContract]
    public partial class InventoryItem : IEquatable<InventoryItem>
    { 
        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="itemId")]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryItem {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InventoryItem)obj);
        }

        /// <summary>
        /// Returns true if InventoryItem instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ItemId == other.ItemId ||
                    ItemId != null &&
                    ItemId.Equals(other.ItemId)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
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
                    if (ItemId != null)
                    hashCode = hashCode * 59 + ItemId.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InventoryItem left, InventoryItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InventoryItem left, InventoryItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
