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
    ///  Class for testing DatasetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatasetsApiTests : IDisposable
    {
        private DatasetsApi instance;

        public DatasetsApiTests()
        {
            instance = new DatasetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatasetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DatasetsApi
            //Assert.IsType<DatasetsApi>(instance);
        }

        /// <summary>
        /// Test ApiDatasetsGet
        /// </summary>
        [Fact]
        public void ApiDatasetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNumber = null;
            //int? pageSize = null;
            //string sortOrder = null;
            //string searchText = null;
            //string filter = null;
            //var response = instance.ApiDatasetsGet(pageNumber, pageSize, sortOrder, searchText, filter);
            //Assert.IsType<DatasetResponsePaginatedResponse>(response);
        }

        /// <summary>
        /// Test ApiDatasetsIdDelete
        /// </summary>
        [Fact]
        public void ApiDatasetsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.ApiDatasetsIdDelete(id);
        }

        /// <summary>
        /// Test ApiDatasetsIdGet
        /// </summary>
        [Fact]
        public void ApiDatasetsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ApiDatasetsIdGet(id);
            //Assert.IsType<DatasetResponse>(response);
        }

        /// <summary>
        /// Test ApiDatasetsIdPut
        /// </summary>
        [Fact]
        public void ApiDatasetsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //ApiDatasetsIdDeleteRequest apiDatasetsIdDeleteRequest = null;
            //instance.ApiDatasetsIdPut(id, apiDatasetsIdDeleteRequest);
        }

        /// <summary>
        /// Test ApiDatasetsPost
        /// </summary>
        [Fact]
        public void ApiDatasetsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DatasetPostRequest datasetPostRequest = null;
            //var response = instance.ApiDatasetsPost(datasetPostRequest);
            //Assert.IsType<DatasetResponse>(response);
        }
    }
}
