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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.NLP.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.NLP.Model
{
    /// <summary>
    /// Input to a language translation operation
    /// </summary>
    [DataContract]
    public partial class LanguageTranslationRequest :  IEquatable<LanguageTranslationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageTranslationRequest" /> class.
        /// </summary>
        /// <param name="textToTranslate">Text to translate.</param>
        public LanguageTranslationRequest(string textToTranslate = default(string))
        {
            this.TextToTranslate = textToTranslate;
        }
        
        /// <summary>
        /// Text to translate
        /// </summary>
        /// <value>Text to translate</value>
        [DataMember(Name="TextToTranslate", EmitDefaultValue=false)]
        public string TextToTranslate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageTranslationRequest {\n");
            sb.Append("  TextToTranslate: ").Append(TextToTranslate).Append("\n");
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
            return this.Equals(input as LanguageTranslationRequest);
        }

        /// <summary>
        /// Returns true if LanguageTranslationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguageTranslationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageTranslationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextToTranslate == input.TextToTranslate ||
                    (this.TextToTranslate != null &&
                    this.TextToTranslate.Equals(input.TextToTranslate))
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
                if (this.TextToTranslate != null)
                    hashCode = hashCode * 59 + this.TextToTranslate.GetHashCode();
                return hashCode;
            }
        }
    }

}
