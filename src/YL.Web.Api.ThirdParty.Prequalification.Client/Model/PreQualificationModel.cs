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
    /// PreQualificationModel
    /// </summary>
    [DataContract]
    public partial class PreQualificationModel :  IEquatable<PreQualificationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreQualificationModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PreQualificationModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PreQualificationModel" /> class.
        /// </summary>
        /// <param name="thirdPartyMerchantId">thirdPartyMerchantId (required).</param>
        /// <param name="mid">mid.</param>
        /// <param name="companyName">companyName (required).</param>
        /// <param name="companyNumber">companyNumber (required).</param>
        /// <param name="companyType">companyType (required).</param>
        /// <param name="companyWebsite">companyWebsite.</param>
        /// <param name="contactEmailAddress">contactEmailAddress.</param>
        /// <param name="countryISOCode">countryISOCode (required).</param>
        /// <param name="loanCurrencyISOCode">loanCurrencyISOCode.</param>
        /// <param name="sicCode">sicCode.</param>
        /// <param name="mccCode">mccCode.</param>
        /// <param name="monthsTrading">monthsTrading.</param>
        /// <param name="financialData">financialData (required).</param>
        /// <param name="significantPersons">significantPersons.</param>
        public PreQualificationModel(string thirdPartyMerchantId = default(string), string mid = default(string), string companyName = default(string), string companyNumber = default(string), string companyType = default(string), string companyWebsite = default(string), string contactEmailAddress = default(string), string countryISOCode = default(string), string loanCurrencyISOCode = default(string), string sicCode = default(string), string mccCode = default(string), int monthsTrading = default(int), FinancialDataModel financialData = default(FinancialDataModel), List<SignificantPersonModel> significantPersons = default(List<SignificantPersonModel>))
        {
            // to ensure "thirdPartyMerchantId" is required (not null)
            if (thirdPartyMerchantId == null)
            {
                throw new InvalidDataException("thirdPartyMerchantId is a required property for PreQualificationModel and cannot be null");
            }
            else
            {
                this.ThirdPartyMerchantId = thirdPartyMerchantId;
            }

            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new InvalidDataException("companyName is a required property for PreQualificationModel and cannot be null");
            }
            else
            {
                this.CompanyName = companyName;
            }

            // to ensure "companyNumber" is required (not null)
            if (companyNumber == null)
            {
                throw new InvalidDataException("companyNumber is a required property for PreQualificationModel and cannot be null");
            }
            else
            {
                this.CompanyNumber = companyNumber;
            }

            // to ensure "companyType" is required (not null)
            if (companyType == null)
            {
                throw new InvalidDataException("companyType is a required property for PreQualificationModel and cannot be null");
            }
            else
            {
                this.CompanyType = companyType;
            }

            // to ensure "countryISOCode" is required (not null)
            if (countryISOCode == null)
            {
                throw new InvalidDataException("countryISOCode is a required property for PreQualificationModel and cannot be null");
            }
            else
            {
                this.CountryISOCode = countryISOCode;
            }

            // to ensure "financialData" is required (not null)
            if (financialData == null)
            {
                throw new InvalidDataException("financialData is a required property for PreQualificationModel and cannot be null");
            }
            else
            {
                this.FinancialData = financialData;
            }

            this.Mid = mid;
            this.CompanyWebsite = companyWebsite;
            this.ContactEmailAddress = contactEmailAddress;
            this.LoanCurrencyISOCode = loanCurrencyISOCode;
            this.SicCode = sicCode;
            this.MccCode = mccCode;
            this.MonthsTrading = monthsTrading;
            this.SignificantPersons = significantPersons;
        }
        
        /// <summary>
        /// Gets or Sets ThirdPartyMerchantId
        /// </summary>
        [DataMember(Name="thirdPartyMerchantId", EmitDefaultValue=false)]
        public string ThirdPartyMerchantId { get; set; }

        /// <summary>
        /// Gets or Sets Mid
        /// </summary>
        [DataMember(Name="mid", EmitDefaultValue=false)]
        public string Mid { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets CompanyNumber
        /// </summary>
        [DataMember(Name="companyNumber", EmitDefaultValue=false)]
        public string CompanyNumber { get; set; }

        /// <summary>
        /// Gets or Sets CompanyType
        /// </summary>
        [DataMember(Name="companyType", EmitDefaultValue=false)]
        public string CompanyType { get; set; }

        /// <summary>
        /// Gets or Sets CompanyWebsite
        /// </summary>
        [DataMember(Name="companyWebsite", EmitDefaultValue=false)]
        public string CompanyWebsite { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmailAddress
        /// </summary>
        [DataMember(Name="contactEmailAddress", EmitDefaultValue=false)]
        public string ContactEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets CountryISOCode
        /// </summary>
        [DataMember(Name="countryISOCode", EmitDefaultValue=false)]
        public string CountryISOCode { get; set; }

        /// <summary>
        /// Gets or Sets LoanCurrencyISOCode
        /// </summary>
        [DataMember(Name="loanCurrencyISOCode", EmitDefaultValue=false)]
        public string LoanCurrencyISOCode { get; set; }

        /// <summary>
        /// Gets or Sets SicCode
        /// </summary>
        [DataMember(Name="sicCode", EmitDefaultValue=false)]
        public string SicCode { get; set; }

        /// <summary>
        /// Gets or Sets MccCode
        /// </summary>
        [DataMember(Name="mccCode", EmitDefaultValue=false)]
        public string MccCode { get; set; }

        /// <summary>
        /// Gets or Sets MonthsTrading
        /// </summary>
        [DataMember(Name="monthsTrading", EmitDefaultValue=false)]
        public int MonthsTrading { get; set; }

        /// <summary>
        /// Gets or Sets FinancialData
        /// </summary>
        [DataMember(Name="financialData", EmitDefaultValue=false)]
        public FinancialDataModel FinancialData { get; set; }

        /// <summary>
        /// Gets or Sets SignificantPersons
        /// </summary>
        [DataMember(Name="significantPersons", EmitDefaultValue=false)]
        public List<SignificantPersonModel> SignificantPersons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreQualificationModel {\n");
            sb.Append("  ThirdPartyMerchantId: ").Append(ThirdPartyMerchantId).Append("\n");
            sb.Append("  Mid: ").Append(Mid).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyNumber: ").Append(CompanyNumber).Append("\n");
            sb.Append("  CompanyType: ").Append(CompanyType).Append("\n");
            sb.Append("  CompanyWebsite: ").Append(CompanyWebsite).Append("\n");
            sb.Append("  ContactEmailAddress: ").Append(ContactEmailAddress).Append("\n");
            sb.Append("  CountryISOCode: ").Append(CountryISOCode).Append("\n");
            sb.Append("  LoanCurrencyISOCode: ").Append(LoanCurrencyISOCode).Append("\n");
            sb.Append("  SicCode: ").Append(SicCode).Append("\n");
            sb.Append("  MccCode: ").Append(MccCode).Append("\n");
            sb.Append("  MonthsTrading: ").Append(MonthsTrading).Append("\n");
            sb.Append("  FinancialData: ").Append(FinancialData).Append("\n");
            sb.Append("  SignificantPersons: ").Append(SignificantPersons).Append("\n");
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
            return this.Equals(input as PreQualificationModel);
        }

        /// <summary>
        /// Returns true if PreQualificationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PreQualificationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreQualificationModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThirdPartyMerchantId == input.ThirdPartyMerchantId ||
                    (this.ThirdPartyMerchantId != null &&
                    this.ThirdPartyMerchantId.Equals(input.ThirdPartyMerchantId))
                ) && 
                (
                    this.Mid == input.Mid ||
                    (this.Mid != null &&
                    this.Mid.Equals(input.Mid))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CompanyNumber == input.CompanyNumber ||
                    (this.CompanyNumber != null &&
                    this.CompanyNumber.Equals(input.CompanyNumber))
                ) && 
                (
                    this.CompanyType == input.CompanyType ||
                    (this.CompanyType != null &&
                    this.CompanyType.Equals(input.CompanyType))
                ) && 
                (
                    this.CompanyWebsite == input.CompanyWebsite ||
                    (this.CompanyWebsite != null &&
                    this.CompanyWebsite.Equals(input.CompanyWebsite))
                ) && 
                (
                    this.ContactEmailAddress == input.ContactEmailAddress ||
                    (this.ContactEmailAddress != null &&
                    this.ContactEmailAddress.Equals(input.ContactEmailAddress))
                ) && 
                (
                    this.CountryISOCode == input.CountryISOCode ||
                    (this.CountryISOCode != null &&
                    this.CountryISOCode.Equals(input.CountryISOCode))
                ) && 
                (
                    this.LoanCurrencyISOCode == input.LoanCurrencyISOCode ||
                    (this.LoanCurrencyISOCode != null &&
                    this.LoanCurrencyISOCode.Equals(input.LoanCurrencyISOCode))
                ) && 
                (
                    this.SicCode == input.SicCode ||
                    (this.SicCode != null &&
                    this.SicCode.Equals(input.SicCode))
                ) && 
                (
                    this.MccCode == input.MccCode ||
                    (this.MccCode != null &&
                    this.MccCode.Equals(input.MccCode))
                ) && 
                (
                    this.MonthsTrading == input.MonthsTrading ||
                    this.MonthsTrading.Equals(input.MonthsTrading)
                ) && 
                (
                    this.FinancialData == input.FinancialData ||
                    (this.FinancialData != null &&
                    this.FinancialData.Equals(input.FinancialData))
                ) && 
                (
                    this.SignificantPersons == input.SignificantPersons ||
                    this.SignificantPersons != null &&
                    input.SignificantPersons != null &&
                    this.SignificantPersons.SequenceEqual(input.SignificantPersons)
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
                if (this.ThirdPartyMerchantId != null)
                    hashCode = hashCode * 59 + this.ThirdPartyMerchantId.GetHashCode();
                if (this.Mid != null)
                    hashCode = hashCode * 59 + this.Mid.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.CompanyNumber != null)
                    hashCode = hashCode * 59 + this.CompanyNumber.GetHashCode();
                if (this.CompanyType != null)
                    hashCode = hashCode * 59 + this.CompanyType.GetHashCode();
                if (this.CompanyWebsite != null)
                    hashCode = hashCode * 59 + this.CompanyWebsite.GetHashCode();
                if (this.ContactEmailAddress != null)
                    hashCode = hashCode * 59 + this.ContactEmailAddress.GetHashCode();
                if (this.CountryISOCode != null)
                    hashCode = hashCode * 59 + this.CountryISOCode.GetHashCode();
                if (this.LoanCurrencyISOCode != null)
                    hashCode = hashCode * 59 + this.LoanCurrencyISOCode.GetHashCode();
                if (this.SicCode != null)
                    hashCode = hashCode * 59 + this.SicCode.GetHashCode();
                if (this.MccCode != null)
                    hashCode = hashCode * 59 + this.MccCode.GetHashCode();
                hashCode = hashCode * 59 + this.MonthsTrading.GetHashCode();
                if (this.FinancialData != null)
                    hashCode = hashCode * 59 + this.FinancialData.GetHashCode();
                if (this.SignificantPersons != null)
                    hashCode = hashCode * 59 + this.SignificantPersons.GetHashCode();
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
            // ThirdPartyMerchantId (string) maxLength
            if(this.ThirdPartyMerchantId != null && this.ThirdPartyMerchantId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThirdPartyMerchantId, length must be less than 255.", new [] { "ThirdPartyMerchantId" });
            }

            // ThirdPartyMerchantId (string) minLength
            if(this.ThirdPartyMerchantId != null && this.ThirdPartyMerchantId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThirdPartyMerchantId, length must be greater than 1.", new [] { "ThirdPartyMerchantId" });
            }

            // CompanyName (string) maxLength
            if(this.CompanyName != null && this.CompanyName.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be less than 200.", new [] { "CompanyName" });
            }

            // CompanyName (string) minLength
            if(this.CompanyName != null && this.CompanyName.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be greater than 2.", new [] { "CompanyName" });
            }

            // CompanyNumber (string) maxLength
            if(this.CompanyNumber != null && this.CompanyNumber.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyNumber, length must be less than 10.", new [] { "CompanyNumber" });
            }

            // CompanyNumber (string) minLength
            if(this.CompanyNumber != null && this.CompanyNumber.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyNumber, length must be greater than 6.", new [] { "CompanyNumber" });
            }

            // CompanyType (string) minLength
            if(this.CompanyType != null && this.CompanyType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyType, length must be greater than 1.", new [] { "CompanyType" });
            }

            // CompanyWebsite (string) maxLength
            if(this.CompanyWebsite != null && this.CompanyWebsite.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyWebsite, length must be less than 255.", new [] { "CompanyWebsite" });
            }

            // CompanyWebsite (string) minLength
            if(this.CompanyWebsite != null && this.CompanyWebsite.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyWebsite, length must be greater than 0.", new [] { "CompanyWebsite" });
            }

            // ContactEmailAddress (string) maxLength
            if(this.ContactEmailAddress != null && this.ContactEmailAddress.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactEmailAddress, length must be less than 255.", new [] { "ContactEmailAddress" });
            }

            // ContactEmailAddress (string) minLength
            if(this.ContactEmailAddress != null && this.ContactEmailAddress.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactEmailAddress, length must be greater than 0.", new [] { "ContactEmailAddress" });
            }

            // ContactEmailAddress (string) pattern
            Regex regexContactEmailAddress = new Regex(@"^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-||_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+([a-z]+|\\d|-|\\.{0,1}|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])?([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))$", RegexOptions.CultureInvariant);
            if (false == regexContactEmailAddress.Match(this.ContactEmailAddress).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactEmailAddress, must match a pattern of " + regexContactEmailAddress, new [] { "ContactEmailAddress" });
            }

            // CountryISOCode (string) minLength
            if(this.CountryISOCode != null && this.CountryISOCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryISOCode, length must be greater than 1.", new [] { "CountryISOCode" });
            }

            // SicCode (string) maxLength
            if(this.SicCode != null && this.SicCode.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SicCode, length must be less than 255.", new [] { "SicCode" });
            }

            // SicCode (string) minLength
            if(this.SicCode != null && this.SicCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SicCode, length must be greater than 0.", new [] { "SicCode" });
            }

            // MccCode (string) maxLength
            if(this.MccCode != null && this.MccCode.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MccCode, length must be less than 255.", new [] { "MccCode" });
            }

            // MccCode (string) minLength
            if(this.MccCode != null && this.MccCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MccCode, length must be greater than 0.", new [] { "MccCode" });
            }

            // MonthsTrading (int) minimum
            if(this.MonthsTrading < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MonthsTrading, must be a value greater than or equal to 0.", new [] { "MonthsTrading" });
            }

            yield break;
        }
    }

}