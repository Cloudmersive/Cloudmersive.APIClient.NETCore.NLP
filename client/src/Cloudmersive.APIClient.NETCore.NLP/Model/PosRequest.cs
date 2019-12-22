/* 
 * nlpapiv2
 *
 * The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
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
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.NLP.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.NLP.Model
{
    /// <summary>
    /// Part of speech tagging request
    /// </summary>
    [DataContract]
    public partial class PosRequest :  IEquatable<PosRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PosRequest" /> class.
        /// </summary>
        /// <param name="InputText">Input text string.</param>
        public PosRequest(string InputText = default(string))
        {
            this.InputText = InputText;
        }
        
        /// <summary>
        /// Input text string
        /// </summary>
        /// <value>Input text string</value>
        [DataMember(Name="InputText", EmitDefaultValue=false)]
        public string InputText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PosRequest {\n");
            sb.Append("  InputText: ").Append(InputText).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PosRequest);
        }

        /// <summary>
        /// Returns true if PosRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PosRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PosRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputText == input.InputText ||
                    (this.InputText != null &&
                    this.InputText.Equals(input.InputText))
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
                if (this.InputText != null)
                    hashCode = hashCode * 59 + this.InputText.GetHashCode();
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
