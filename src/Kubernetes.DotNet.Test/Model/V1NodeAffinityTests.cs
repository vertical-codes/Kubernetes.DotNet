/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Model;
using Kubernetes.DotNet.Client;
using System.Reflection;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    ///  Class for testing V1NodeAffinity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class V1NodeAffinityTests
    {
        // TODO uncomment below to declare an instance variable for V1NodeAffinity
        //private V1NodeAffinity instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of V1NodeAffinity
            //instance = new V1NodeAffinity();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V1NodeAffinity
        /// </summary>
        [Test]
        public void V1NodeAffinityInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" V1NodeAffinity
            //Assert.IsInstanceOfType<V1NodeAffinity> (instance, "variable 'instance' is a V1NodeAffinity");
        }

        /// <summary>
        /// Test the property 'PreferredDuringSchedulingIgnoredDuringExecution'
        /// </summary>
        [Test]
        public void PreferredDuringSchedulingIgnoredDuringExecutionTest()
        {
            // TODO unit test for the property 'PreferredDuringSchedulingIgnoredDuringExecution'
        }
        /// <summary>
        /// Test the property 'RequiredDuringSchedulingIgnoredDuringExecution'
        /// </summary>
        [Test]
        public void RequiredDuringSchedulingIgnoredDuringExecutionTest()
        {
            // TODO unit test for the property 'RequiredDuringSchedulingIgnoredDuringExecution'
        }

    }

}
