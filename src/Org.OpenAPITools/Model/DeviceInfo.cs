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
    /// DeviceInfo
    /// </summary>
    [DataContract(Name = "DeviceInfo")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(DeviceInfo), "DeviceInfo")]
    public partial class DeviceInfo : DeviceInfoBase, IEquatable<DeviceInfo>, IValidatableObject
    {
        /// <summary>
        /// The platform of the device
        /// </summary>
        /// <value>The platform of the device</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 1,

            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            IOS = 2,

            /// <summary>
            /// Enum WindowsPhone for value: WindowsPhone
            /// </summary>
            [EnumMember(Value = "WindowsPhone")]
            WindowsPhone = 3,

            /// <summary>
            /// Enum Windows for value: Windows
            /// </summary>
            [EnumMember(Value = "Windows")]
            Windows = 4,

            /// <summary>
            /// Enum WindowsTablet for value: WindowsTablet
            /// </summary>
            [EnumMember(Value = "WindowsTablet")]
            WindowsTablet = 5,

            /// <summary>
            /// Enum SurfaceHub for value: SurfaceHub
            /// </summary>
            [EnumMember(Value = "SurfaceHub")]
            SurfaceHub = 6,

            /// <summary>
            /// Enum Xbox for value: Xbox
            /// </summary>
            [EnumMember(Value = "Xbox")]
            Xbox = 7,

            /// <summary>
            /// Enum IoT for value: IoT
            /// </summary>
            [EnumMember(Value = "IoT")]
            IoT = 8,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 9,

            /// <summary>
            /// Enum TvOS for value: tvOS
            /// </summary>
            [EnumMember(Value = "tvOS")]
            TvOS = 10,

            /// <summary>
            /// Enum WatchOS for value: watchOS
            /// </summary>
            [EnumMember(Value = "watchOS")]
            WatchOS = 11,

            /// <summary>
            /// Enum MacOS for value: macOS
            /// </summary>
            [EnumMember(Value = "macOS")]
            MacOS = 12,

            /// <summary>
            /// Enum Tizen for value: Tizen
            /// </summary>
            [EnumMember(Value = "Tizen")]
            Tizen = 13

        }


        /// <summary>
        /// The platform of the device
        /// </summary>
        /// <value>The platform of the device</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public PlatformEnum Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="platform">The platform of the device (required).</param>
        /// <param name="model">The device model.</param>
        /// <param name="manufacturer">The device manufacturer.</param>
        /// <param name="deviceName">The device name.</param>
        /// <param name="deviceVersion">The device version.</param>
        /// <param name="appVersion">The version of the scanning application.</param>
        /// <param name="appBuild">The build version of the scanning application.</param>
        /// <param name="type">type (required) (default to &quot;DeviceInfo&quot;).</param>
        public DeviceInfo(string id = default(string), PlatformEnum platform = default(PlatformEnum), string model = default(string), string manufacturer = default(string), string deviceName = default(string), string deviceVersion = default(string), string appVersion = default(string), string appBuild = default(string), string type = "DeviceInfo") : base(type)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DeviceInfo and cannot be null");
            }
            this.Id = id;
            this.Platform = platform;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.DeviceName = deviceName;
            this.DeviceVersion = deviceVersion;
            this.AppVersion = appVersion;
            this.AppBuild = appBuild;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The device model
        /// </summary>
        /// <value>The device model</value>
        [DataMember(Name = "model", EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// The device manufacturer
        /// </summary>
        /// <value>The device manufacturer</value>
        [DataMember(Name = "manufacturer", EmitDefaultValue = true)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The device name
        /// </summary>
        /// <value>The device name</value>
        [DataMember(Name = "deviceName", EmitDefaultValue = true)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The device version
        /// </summary>
        /// <value>The device version</value>
        [DataMember(Name = "deviceVersion", EmitDefaultValue = true)]
        public string DeviceVersion { get; set; }

        /// <summary>
        /// The version of the scanning application
        /// </summary>
        /// <value>The version of the scanning application</value>
        [DataMember(Name = "appVersion", EmitDefaultValue = true)]
        public string AppVersion { get; set; }

        /// <summary>
        /// The build version of the scanning application
        /// </summary>
        /// <value>The build version of the scanning application</value>
        [DataMember(Name = "appBuild", EmitDefaultValue = true)]
        public string AppBuild { get; set; }

        /// <summary>
        /// The schema version of this object
        /// </summary>
        /// <value>The schema version of this object</value>
        [DataMember(Name = "schemaVer", EmitDefaultValue = false)]
        public int SchemaVer { get; private set; }

        /// <summary>
        /// Returns false as SchemaVer should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSchemaVer()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceInfo {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  DeviceVersion: ").Append(DeviceVersion).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  AppBuild: ").Append(AppBuild).Append("\n");
            sb.Append("  SchemaVer: ").Append(SchemaVer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DeviceInfo);
        }

        /// <summary>
        /// Returns true if DeviceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && base.Equals(input) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && base.Equals(input) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && base.Equals(input) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && base.Equals(input) && 
                (
                    this.DeviceVersion == input.DeviceVersion ||
                    (this.DeviceVersion != null &&
                    this.DeviceVersion.Equals(input.DeviceVersion))
                ) && base.Equals(input) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && base.Equals(input) && 
                (
                    this.AppBuild == input.AppBuild ||
                    (this.AppBuild != null &&
                    this.AppBuild.Equals(input.AppBuild))
                ) && base.Equals(input) && 
                (
                    this.SchemaVer == input.SchemaVer ||
                    this.SchemaVer.Equals(input.SchemaVer)
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
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.Manufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.Manufacturer.GetHashCode();
                }
                if (this.DeviceName != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceName.GetHashCode();
                }
                if (this.DeviceVersion != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceVersion.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.AppBuild != null)
                {
                    hashCode = (hashCode * 59) + this.AppBuild.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchemaVer.GetHashCode();
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
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
