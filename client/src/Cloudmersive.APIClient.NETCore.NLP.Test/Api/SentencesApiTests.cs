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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NETCore.NLP.Client;
using Cloudmersive.APIClient.NETCore.NLP.Api;

namespace Cloudmersive.APIClient.NETCore.NLP.Test
{
    /// <summary>
    ///  Class for testing SentencesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SentencesApiTests
    {
        private SentencesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SentencesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SentencesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SentencesApi
            //Assert.IsInstanceOfType(typeof(SentencesApi), instance, "instance is a SentencesApi");
        }

        
        /// <summary>
        /// Test SentencesPost
        /// </summary>
        [Test]
        public void SentencesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string input = null;
            //var response = instance.SentencesPost(input);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
