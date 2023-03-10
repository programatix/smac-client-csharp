/*
 * SMAC API
 *
 * SMAC ASP.NET Core Web API
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing SmacsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SmacsApiTests : IDisposable
    {
        private SmacsApi instance;

        public SmacsApiTests()
        {
            instance = new SmacsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SmacsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SmacsApi
            //Assert.IsType<SmacsApi>(instance);
        }

        /// <summary>
        /// Test ApiSmacsGet
        /// </summary>
        [Fact]
        public void ApiSmacsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNumber = null;
            //int? pageSize = null;
            //string sortOrder = null;
            //string searchText = null;
            //string filter = null;
            //var response = instance.ApiSmacsGet(pageNumber, pageSize, sortOrder, searchText, filter);
            //Assert.IsType<SmacResponsePaginatedResponse>(response);
        }

        /// <summary>
        /// Test ApiSmacsIdDelete
        /// </summary>
        [Fact]
        public void ApiSmacsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.ApiSmacsIdDelete(id);
        }

        /// <summary>
        /// Test ApiSmacsIdGeneratePost
        /// </summary>
        [Fact]
        public void ApiSmacsIdGeneratePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //SmacGenerateRequest smacGenerateRequest = null;
            //var response = instance.ApiSmacsIdGeneratePost(id, smacGenerateRequest);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ApiSmacsIdGet
        /// </summary>
        [Fact]
        public void ApiSmacsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ApiSmacsIdGet(id);
            //Assert.IsType<SmacResponse>(response);
        }

        /// <summary>
        /// Test ApiSmacsIdPngGet
        /// </summary>
        [Fact]
        public void ApiSmacsIdPngGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //int? size = null;
            //var response = instance.ApiSmacsIdPngGet(id, size);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ApiSmacsIdPut
        /// </summary>
        [Fact]
        public void ApiSmacsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //ApiSmacsIdDeleteRequest apiSmacsIdDeleteRequest = null;
            //instance.ApiSmacsIdPut(id, apiSmacsIdDeleteRequest);
        }

        /// <summary>
        /// Test ApiSmacsIdSvgGet
        /// </summary>
        [Fact]
        public void ApiSmacsIdSvgGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ApiSmacsIdSvgGet(id);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ApiSmacsPost
        /// </summary>
        [Fact]
        public void ApiSmacsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmacPostRequest smacPostRequest = null;
            //var response = instance.ApiSmacsPost(smacPostRequest);
            //Assert.IsType<SmacResponse>(response);
        }
    }
}
