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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DatasetRequest
    /// </summary>
    [DataContract(Name = "DatasetRequest")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(DatasetPostRequest), "DatasetPostRequest")]
    [JsonSubtypes.KnownSubType(typeof(DatasetRequest), "DatasetRequest")]
    public partial class DatasetRequest : IEquatable<DatasetRequest>, IValidatableObject
    {
        /// <summary>
        /// A comma separated list of associated user types permitted to view this dataset    The value can be:  - None  - Holder  - Coholder
        /// </summary>
        /// <value>A comma separated list of associated user types permitted to view this dataset    The value can be:  - None  - Holder  - Coholder</value>
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
        /// A comma separated list of associated user types permitted to view this dataset    The value can be:  - None  - Holder  - Coholder
        /// </summary>
        /// <value>A comma separated list of associated user types permitted to view this dataset    The value can be:  - None  - Holder  - Coholder</value>
        [DataMember(Name = "viewableByAssociatedUserTypes", EmitDefaultValue = true)]
        public ViewableByAssociatedUserTypesEnum? ViewableByAssociatedUserTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatasetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRequest" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="name">The dataset name.</param>
        /// <param name="localizedNames">Localized dataset name.</param>
        /// <param name="description">The dataset description.</param>
        /// <param name="payloadId">The payload identifier to attach.</param>
        /// <param name="ruleIds">The rule identifier(s) to attach.</param>
        /// <param name="viewableByAssociatedUserTypes">A comma separated list of associated user types permitted to view this dataset    The value can be:  - None  - Holder  - Coholder.</param>
        public DatasetRequest(string type = default(string), string name = default(string), string localizedNames = default(string), string description = default(string), Guid payloadId = default(Guid), List<Guid> ruleIds = default(List<Guid>), ViewableByAssociatedUserTypesEnum? viewableByAssociatedUserTypes = default(ViewableByAssociatedUserTypesEnum?))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for DatasetRequest and cannot be null");
            }
            this.Type = type;
            this.Name = name;
            this.LocalizedNames = localizedNames;
            this.Description = description;
            this.PayloadId = payloadId;
            this.RuleIds = ruleIds;
            this.ViewableByAssociatedUserTypes = viewableByAssociatedUserTypes;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The dataset name
        /// </summary>
        /// <value>The dataset name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Localized dataset name
        /// </summary>
        /// <value>Localized dataset name</value>
        [DataMember(Name = "localizedNames", EmitDefaultValue = true)]
        public string LocalizedNames { get; set; }

        /// <summary>
        /// The dataset description
        /// </summary>
        /// <value>The dataset description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The payload identifier to attach
        /// </summary>
        /// <value>The payload identifier to attach</value>
        [DataMember(Name = "payloadId", EmitDefaultValue = false)]
        public Guid PayloadId { get; set; }

        /// <summary>
        /// The rule identifier(s) to attach
        /// </summary>
        /// <value>The rule identifier(s) to attach</value>
        [DataMember(Name = "ruleIds", EmitDefaultValue = true)]
        public List<Guid> RuleIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocalizedNames: ").Append(LocalizedNames).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PayloadId: ").Append(PayloadId).Append("\n");
            sb.Append("  RuleIds: ").Append(RuleIds).Append("\n");
            sb.Append("  ViewableByAssociatedUserTypes: ").Append(ViewableByAssociatedUserTypes).Append("\n");
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
            return this.Equals(input as DatasetRequest);
        }

        /// <summary>
        /// Returns true if DatasetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // LocalizedNames (string) pattern
            Regex regexLocalizedNames = new Regex(@"((^|(([\\t\\n\\r\\s]+)?,))([\\t\\n\\r\\s]+)?(\""\\w+\""):(\""[^\""]+\""))+", RegexOptions.CultureInvariant);
            if (false == regexLocalizedNames.Match(this.LocalizedNames).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalizedNames, must match a pattern of " + regexLocalizedNames, new [] { "LocalizedNames" });
            }

            yield break;
        }
    }

}