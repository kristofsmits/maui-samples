/*
 * OpenAPI definition
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v0
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

using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Api;

namespace BlueSpot.Client.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing DatatypesControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatatypesControllerApiTests : IDisposable
    {
        private DatatypesControllerApi instance;

        public DatatypesControllerApiTests()
        {
            instance = new DatatypesControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatatypesControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DatatypesControllerApi
            //Assert.IsType<DatatypesControllerApi>(instance);
        }

        /// <summary>
        /// Test GetDatatypes
        /// </summary>
        [Fact]
        public void GetDatatypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDatatypes();
            //Assert.IsType<string>(response);
        }
    }
}
