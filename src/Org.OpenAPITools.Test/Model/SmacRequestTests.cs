/*
 * SMAC API
 *
 * SMAC ASP.NET Core Web API
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing SmacRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SmacRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SmacRequest
        //private SmacRequest instance;

        public SmacRequestTests()
        {
            // TODO uncomment below to create an instance of SmacRequest
            //instance = new SmacRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SmacRequest
        /// </summary>
        [Fact]
        public void SmacRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SmacRequest
            //Assert.IsType<SmacRequest>(instance);
        }

        /// <summary>
        /// Test deserialize a SmacPostRequest from type SmacRequest
        /// </summary>
        [Fact]
        public void SmacPostRequestDeserializeFromSmacRequestTest()
        {
            // TODO uncomment below to test deserialize a SmacPostRequest from type SmacRequest
            //Assert.IsType<SmacRequest>(JsonConvert.DeserializeObject<SmacRequest>(new SmacPostRequest().ToJson()));
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Datasets'
        /// </summary>
        [Fact]
        public void DatasetsTest()
        {
            // TODO unit test for the property 'Datasets'
        }
        /// <summary>
        /// Test the property 'AssociatedUsers'
        /// </summary>
        [Fact]
        public void AssociatedUsersTest()
        {
            // TODO unit test for the property 'AssociatedUsers'
        }

    }

}
