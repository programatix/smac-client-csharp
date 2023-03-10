/*
 * SMAC API
 *
 * SMAC ASP.NET Core Web API
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DatasetResponse
    /// </summary>
    [DataContract(Name = "DatasetResponse")]
    public partial class DatasetResponse : IEquatable<DatasetResponse>, IValidatableObject
    {
        /// <summary>
        /// A comma separated list of associated user types permitted to view this dataset
        /// </summary>
        /// <value>A comma separated list of associated user types permitted to view this dataset</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewableByAssociatedUserTypesEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Holder for value: Holder
            /// </summary>
            [EnumMember(Value = "Holder")]
            Holder = 2,

            /// <summary>
            /// Enum Coholder for value: Coholder
            /// </summary>
            [EnumMember(Value = "Coholder")]
            Coholder = 3

        }


        /// <summary>
        /// A comma separated list of associated user types permitted to view this dataset
        /// </summary>
        /// <value>A comma separated list of associated user types permitted to view this dataset</value>
        [DataMember(Name = "viewableByAssociatedUserTypes", EmitDefaultValue = true)]
        public ViewableByAssociatedUserTypesEnum? ViewableByAssociatedUserTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetResponse" /> class.
        /// </summary>
        /// <param name="id">The dataset identifier.</param>
        /// <param name="name">The dataset name.</param>
        /// <param name="localizedNames">The localized dataset name.</param>
        /// <param name="description">The dataset description.</param>
        /// <param name="payloadId">The attached payload identifier.</param>
        /// <param name="ruleIds">The attached rule identifier(s).</param>
        /// <param name="viewableByAssociatedUserTypes">A comma separated list of associated user types permitted to view this dataset.</param>
        /// <param name="usageCount">The usage count (It indicates the number of SMAC(s) it is attached to.).</param>
        public DatasetResponse(Guid id = default(Guid), string name = default(string), string localizedNames = default(string), string description = default(string), Guid payloadId = default(Guid), List<Guid> ruleIds = default(List<Guid>), ViewableByAssociatedUserTypesEnum? viewableByAssociatedUserTypes = default(ViewableByAssociatedUserTypesEnum?), int usageCount = default(int))
        {
            this.Id = id;
            this.Name = name;
            this.LocalizedNames = localizedNames;
            this.Description = description;
            this.PayloadId = payloadId;
            this.RuleIds = ruleIds;
            this.ViewableByAssociatedUserTypes = viewableByAssociatedUserTypes;
            this.UsageCount = usageCount;
        }

        /// <summary>
        /// The dataset identifier
        /// </summary>
        /// <value>The dataset identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The dataset name
        /// </summary>
        /// <value>The dataset name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The localized dataset name
        /// </summary>
        /// <value>The localized dataset name</value>
        [DataMember(Name = "localizedNames", EmitDefaultValue = true)]
        public string LocalizedNames { get; set; }

        /// <summary>
        /// The dataset description
        /// </summary>
        /// <value>The dataset description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The attached payload identifier
        /// </summary>
        /// <value>The attached payload identifier</value>
        [DataMember(Name = "payloadId", EmitDefaultValue = false)]
        public Guid PayloadId { get; set; }

        /// <summary>
        /// The attached rule identifier(s)
        /// </summary>
        /// <value>The attached rule identifier(s)</value>
        [DataMember(Name = "ruleIds", EmitDefaultValue = true)]
        public List<Guid> RuleIds { get; set; }

        /// <summary>
        /// The usage count (It indicates the number of SMAC(s) it is attached to.)
        /// </summary>
        /// <value>The usage count (It indicates the number of SMAC(s) it is attached to.)</value>
        [DataMember(Name = "usageCount", EmitDefaultValue = false)]
        public int UsageCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocalizedNames: ").Append(LocalizedNames).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PayloadId: ").Append(PayloadId).Append("\n");
            sb.Append("  RuleIds: ").Append(RuleIds).Append("\n");
            sb.Append("  ViewableByAssociatedUserTypes: ").Append(ViewableByAssociatedUserTypes).Append("\n");
            sb.Append("  UsageCount: ").Append(UsageCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatasetResponse);
        }

        /// <summary>
        /// Returns true if DatasetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocalizedNames == input.LocalizedNames ||
                    (this.LocalizedNames != null &&
                    this.LocalizedNames.Equals(input.LocalizedNames))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PayloadId == input.PayloadId ||
                    (this.PayloadId != null &&
                    this.PayloadId.Equals(input.PayloadId))
                ) && 
                (
                    this.RuleIds == input.RuleIds ||
                    this.RuleIds != null &&
                    input.RuleIds != null &&
                    this.RuleIds.SequenceEqual(input.RuleIds)
                ) && 
                (
                    this.ViewableByAssociatedUserTypes == input.ViewableByAssociatedUserTypes ||
                    this.ViewableByAssociatedUserTypes.Equals(input.ViewableByAssociatedUserTypes)
                ) && 
                (
                    this.UsageCount == input.UsageCount ||
                    this.UsageCount.Equals(input.UsageCount)
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LocalizedNames != null)
                {
                    hashCode = (hashCode * 59) + this.LocalizedNames.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.PayloadId != null)
                {
                    hashCode = (hashCode * 59) + this.PayloadId.GetHashCode();
                }
                if (this.RuleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RuleIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ViewableByAssociatedUserTypes.GetHashCode();
                hashCode = (hashCode * 59) + this.UsageCount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
