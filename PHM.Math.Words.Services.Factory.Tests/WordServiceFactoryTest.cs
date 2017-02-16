//-----------------------------------------------------------------------
// <copyright file="WordServiceFactoryTest.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Services.Factory.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Services;

    /// <summary>
    /// Word service factory test
    /// </summary>
    [TestFixture]
    public class WordServiceFactoryTest
    {
        /// <summary>
        /// Should the word service factory provide fizz buzz service when fizz buzz feed service is requested.
        /// </summary>
        [Test]
        public void Should_WordServiceFactory_Provide_FizzBuzzService_When_FizzBuzz_ServiceType()
        {
            var numberWordService = new WordServiceFactory().GetNumberWordService("FizzBuzz");
            Assert.IsInstanceOf(typeof(FizzBuzzWordService), numberWordService);
        }

        /// <summary>
        /// Should the word service throw keynotfound exception when invalid service type is specified
        /// </summary>
        [Test]
        public void Should_WordServiceFactory_Throw_KeyNotFoundException_When_Invalid_ServiceType()
        {
            var factory = new WordServiceFactory();
            Assert.Throws<KeyNotFoundException>(() => factory.GetNumberWordService(""));
            Assert.Throws<KeyNotFoundException>(() => factory.GetNumberWordService("TestFeed"));
        }

        /// <summary>
        /// Should the word service throw keynotfound exception when service type is null
        /// </summary>
        [Test]
        public void Should_WordServiceFactory_Throw_ArgumentNullException_When_Null_ServiceType()
        {
            var factory = new WordServiceFactory();
            Assert.Throws<ArgumentNullException>(() => factory.GetNumberWordService(null));
        }
    }
}
