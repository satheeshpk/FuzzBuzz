//-----------------------------------------------------------------------
// <copyright file="FizzBuzzViewModelTest.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Tests
{   
    using System;
    using NUnit.Framework;
    using ViewModels;

    /// <summary>
    /// Fizz Buzz view model test
    /// </summary>
    [TestFixture]
    public class FizzBuzzViewModelTest
    {
        /// <summary>
        /// The argument exception message
        /// </summary>
        const string ArgumentExceptionMessage = "The value should be a non zero and non-negative number.";

        /// <summary>
        /// Should the fizz buzz view model initial fizz buzz result is empty.
        /// </summary>
        [Test]
        public void Should_FizzBuzzViewModel_Initial_FizzBuzzResult_IsEmpty()
        {
            var fizzBuzzModel = new FizzBuzzViewModel();

            Assert.IsEmpty(fizzBuzzModel.FizzBuzzResult);
        }

        /// <summary>
        /// Should the fizz buzz view model set the result empty when number is zero.
        /// </summary>
        [Test]
        public void Should_FizzBuzzViewModel_When_Number_Zero_Then_Set_Result_Empty()
        {
            var fizzBuzzModel = new FizzBuzzViewModel();
            fizzBuzzModel.Number = 0;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            Assert.IsEmpty(fizzBuzzModel.FizzBuzzResult);
        }

        /// <summary>
        /// Should the fizz buzz view model set the result empty when number is zero.
        /// </summary>
        [Test]
        public void Should_FizzBuzzViewModel_When_Number_Negative_Then_Set_Result_Empty()
        {
            var fizzBuzzModel = new FizzBuzzViewModel();
            fizzBuzzModel.Number = -15;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            fizzBuzzModel.Number = -22;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            Assert.IsEmpty(fizzBuzzModel.FizzBuzzResult);
        }

        /// <summary>
        /// Should the fizz buzz view model returns fizz when number multiple of three.
        /// </summary>
        /// <returns></returns>
        [Test]
        public void Should_FizzBuzzViewModel_When_Number_Null_Then_Set_Result_Emtpy()
        {
            var fizzBuzzModel = new FizzBuzzViewModel();
            fizzBuzzModel.Number = 15;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            fizzBuzzModel.Number = null;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            Assert.IsEmpty(fizzBuzzModel.FizzBuzzResult);
        }

        /// <summary>
        /// Should the fizz buzz view model returns fizz when number multiple of three.
        /// </summary>
        /// <returns></returns>
        [Test]
        public void Should_FizzBuzzViewModel_When_Number_Multiple_Of_Three_Then_Result_Fizz()
        {
            var fizzBuzzModel = new FizzBuzzViewModel();
            fizzBuzzModel.Number = 12;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            StringAssert.AreEqualIgnoringCase("Fizz", fizzBuzzModel.FizzBuzzResult);

            fizzBuzzModel.Number = 30;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            StringAssert.AreEqualIgnoringCase("Fizz", fizzBuzzModel.FizzBuzzResult);
        }

        /// <summary>
        /// Should the fizz buzz view model returns fizz when number multiple of five.
        /// </summary>
        /// <returns></returns>
        [Test]
        public void Should_FizzBuzzViewModel_When_Number_Multiple_Of_Five_Then_Result_Buzz()
        {
            var fizzBuzzModel = new FizzBuzzViewModel();
            fizzBuzzModel.Number = 25;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            StringAssert.AreEqualIgnoringCase("Buzz", fizzBuzzModel.FizzBuzzResult);

            fizzBuzzModel.Number = 1025;
            fizzBuzzModel.FizzBuzz.Execute(string.Empty);

            StringAssert.AreEqualIgnoringCase("Buzz", fizzBuzzModel.FizzBuzzResult);
        }
    }
}
