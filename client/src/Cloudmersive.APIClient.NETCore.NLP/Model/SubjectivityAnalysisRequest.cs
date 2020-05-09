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
    /// Input to a subjectivity analysis operation
    /// </summary>
    [DataContract]
    public partial class SubjectivityAnalysisRequest :  IEquatable<SubjectivityAnalysisRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectivityAnalysisRequest" /> class.
        /// </summary>
        /// <param name="textToAnalyze">Text to analyze.</param>
        public SubjectivityAnalysisRequest(string textToAnalyze = default(string))
        {
            this.TextToAnalyze = textToAnalyze;
        }
        
        /// <summary>
        /// Text to analyze
        /// </summary>
        /// <value>Text to analyze</value>
        [DataMember(Name="TextToAnalyze", EmitDefaultValue=false)]
        public string TextToAnalyze { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubjectivityAnalysisRequest {\n");
            sb.Append("  TextToAnalyze: ").Append(TextToAnalyze).Append("\n");
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
            return this.Equals(input as SubjectivityAnalysisRequest);
        }

        /// <summary>
        /// Returns true if SubjectivityAnalysisRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubjectivityAnalysisRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubjectivityAnalysisRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextToAnalyze == input.TextToAnalyze ||
                    (this.TextToAnalyze != null &&
                    this.TextToAnalyze.Equals(input.TextToAnalyze))
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
                if (this.TextToAnalyze != null)
                    hashCode = hashCode * 59 + this.TextToAnalyze.GetHashCode();
                return hashCode;
            }
        }
    }

}
