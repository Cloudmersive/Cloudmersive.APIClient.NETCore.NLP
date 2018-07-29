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
    /// A word in a sentence
    /// </summary>
    [DataContract]
    public partial class CorrectWordInSentenceJsonResponse :  IEquatable<CorrectWordInSentenceJsonResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectWordInSentenceJsonResponse" /> class.
        /// </summary>
        /// <param name="Word">Position of the word.</param>
        /// <param name="Correct">True if the word is spelled correctly, false otherwise.</param>
        /// <param name="Suggestions">Suggested spelling improvements.</param>
        public CorrectWordInSentenceJsonResponse(WordPosition Word = default(WordPosition), bool? Correct = default(bool?), List<string> Suggestions = default(List<string>))
        {
            this.Word = Word;
            this.Correct = Correct;
            this.Suggestions = Suggestions;
        }
        
        /// <summary>
        /// Position of the word
        /// </summary>
        /// <value>Position of the word</value>
        [DataMember(Name="Word", EmitDefaultValue=false)]
        public WordPosition Word { get; set; }

        /// <summary>
        /// True if the word is spelled correctly, false otherwise
        /// </summary>
        /// <value>True if the word is spelled correctly, false otherwise</value>
        [DataMember(Name="Correct", EmitDefaultValue=false)]
        public bool? Correct { get; set; }

        /// <summary>
        /// Suggested spelling improvements
        /// </summary>
        /// <value>Suggested spelling improvements</value>
        [DataMember(Name="Suggestions", EmitDefaultValue=false)]
        public List<string> Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorrectWordInSentenceJsonResponse {\n");
            sb.Append("  Word: ").Append(Word).Append("\n");
            sb.Append("  Correct: ").Append(Correct).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            return this.Equals(input as CorrectWordInSentenceJsonResponse);
        }

        /// <summary>
        /// Returns true if CorrectWordInSentenceJsonResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CorrectWordInSentenceJsonResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorrectWordInSentenceJsonResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Word == input.Word ||
                    (this.Word != null &&
                    this.Word.Equals(input.Word))
                ) && 
                (
                    this.Correct == input.Correct ||
                    (this.Correct != null &&
                    this.Correct.Equals(input.Correct))
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    this.Suggestions != null &&
                    this.Suggestions.SequenceEqual(input.Suggestions)
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
                if (this.Word != null)
                    hashCode = hashCode * 59 + this.Word.GetHashCode();
                if (this.Correct != null)
                    hashCode = hashCode * 59 + this.Correct.GetHashCode();
                if (this.Suggestions != null)
                    hashCode = hashCode * 59 + this.Suggestions.GetHashCode();
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
