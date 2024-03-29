/* 
 * YouLend Third Party Pre Qualification API
 *
 * Through this API you can can check if a merchant pre qualifies for a Youlend loan
 *
 * The version of the OpenAPI document: 1.0
 * Contact: mark.ufland@youlend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = YL.Web.Api.ThirdParty.Prequalification.Client.Client.OpenAPIDateConverter;

namespace YL.Web.Api.ThirdParty.Prequalification.Client.Model
{
    /// <summary>
    /// SignificantPersonModel
    /// </summary>
    [DataContract]
    public partial class SignificantPersonModel :  IEquatable<SignificantPersonModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignificantPersonModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignificantPersonModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignificantPersonModel" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="surname">surname (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="dateOfBirth">dateOfBirth (required).</param>
        public SignificantPersonModel(string firstName = default(string), string surname = default(string), AddressModel address = default(AddressModel), DateTime dateOfBirth = default(DateTime))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for SignificantPersonModel and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }

            // to ensure "surname" is required (not null)
            if (surname == null)
            {
                throw new InvalidDataException("surname is a required property for SignificantPersonModel and cannot be null");
            }
            else
            {
                this.Surname = surname;
            }

            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for SignificantPersonModel and cannot be null");
            }
            else
            {
                this.Address = address;
            }

            // to ensure "dateOfBirth" is required (not null)
            if (dateOfBirth == null)
            {
                throw new InvalidDataException("dateOfBirth is a required property for SignificantPersonModel and cannot be null");
            }
            else
            {
                this.DateOfBirth = dateOfBirth;
            }

        }
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AddressModel Address { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignificantPersonModel {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
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
            return this.Equals(input as SignificantPersonModel);
        }

        /// <summary>
        /// Returns true if SignificantPersonModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SignificantPersonModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignificantPersonModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
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
            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 255.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if(this.FirstName != null && this.FirstName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 1.", new [] { "FirstName" });
            }

            // Surname (string) maxLength
            if(this.Surname != null && this.Surname.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Surname, length must be less than 255.", new [] { "Surname" });
            }

            // Surname (string) minLength
            if(this.Surname != null && this.Surname.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Surname, length must be greater than 1.", new [] { "Surname" });
            }

            yield break;
        }
    }

}
