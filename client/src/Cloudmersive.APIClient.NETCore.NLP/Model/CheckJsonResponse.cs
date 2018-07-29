/* 
 * nlpapi
 *
 * The powerful Natural Language Processing APIs let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
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
    /// Spell check result
    /// </summary>
    [DataContract]
    public partial class CheckJsonResponse :  IEquatable<CheckJsonResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckJsonResponse" /> class.
        /// </summary>
        /// <param name="Correct">True if spellected correctly, false otherwise.</param>
        public CheckJsonResponse(bool? Correct = default(bool?))
        {
            this.Correct = Correct;
        }
        
        /// <summary>
        /// True if spellected correctly, false otherwise
        /// </summary>
        /// <value>True if spellected correctly, false otherwise</value>
        [DataMember(Name="Correct", EmitDefaultValue=false)]
        public bool? Correct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckJsonResponse {\n");
            sb.Append("  Correct: ").Append(Correct).Append("\n");
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
            return this.Equals(input as CheckJsonResponse);
        }

        /// <summary>
        /// Returns true if CheckJsonResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckJsonResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckJsonResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Correct == input.Correct ||
                    (this.Correct != null &&
                    this.Correct.Equals(input.Correct))
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
                if (this.Correct != null)
                    hashCode = hashCode * 59 + this.Correct.GetHashCode();
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
