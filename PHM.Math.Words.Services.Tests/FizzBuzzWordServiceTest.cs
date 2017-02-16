//-----------------------------------------------------------------------
// <copyright file="FizzBuzzWordServiceTest.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Services.Tests
{
    using NUnit.Framework;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Fizz buzz word service test
    /// </summary>
    [TestFixture]
    public class FizzBuzzWordServiceTest
    {
        const string FizzWord = "Fizz";
        const string BuzzWord = "Buzz";
        const string ArgumentExceptionMessage = "The value should be a non zero and non-negative number.";

        /// <summary>
        /// Should the fizz buzz word service return fizz for input of mulitples of three.
        /// </summary>
        /// <returns>the awaitable task</returns>
        [Test]
        public async Task Should_FizzBuzzWordService_Return_Fizz_For_Input_Mulitples_Of_Three()
        {
            var fizzBuzzWordService = new FizzBuzzWordService();

            StringAssert.AreEqualIgnoringCase(FizzWord, await fizzBuzzWordService.GetWord(15));
            StringAssert.AreEqualIgnoringCase(FizzWord, await fizzBuzzWordService.GetWord(30));
            StringAssert.AreEqualIgnoringCase(FizzWord, await fizzBuzzWordService.GetWord(21));
        }

        /// <summary>
        /// Should the fizz buzz word service return fizz for input of mulitples of five.
        /// </summary>
        /// <returns>the awaitable task</returns>
        [Test]
        public async Task Should_FizzBuzzWordService_Return_Fizz_For_Input_Mulitples_Of_Five()
        {
            var fizzBuzzWordService = new FizzBuzzWordService();

            StringAssert.AreEqualIgnoringCase(BuzzWord, await fizzBuzzWordService.GetWord(25));
            StringAssert.AreEqualIgnoringCase(BuzzWord, await fizzBuzzWordService.GetWord(200));
            StringAssert.AreEqualIgnoringCase(BuzzWord, await fizzBuzzWordService.GetWord(775));
        }

        /// <summary>
        /// Should the fizz buzz word service return empty for input of non multiples of three or five.
        /// </summary>
        /// <returns>the awaitable task</returns>
        [Test]
        public async Task Should_FizzBuzzWordService_Return_Empty_For_Input_Non_Multiples_Of_Three_Or_Five()
        {
            var fizzBuzzWordService = new FizzBuzzWordService();

            StringAssert.AreEqualIgnoringCase(string.Empty, await fizzBuzzWordService.GetWord(2));
            StringAssert.AreEqualIgnoringCase(string.Empty, await fizzBuzzWordService.GetWord(28));
            StringAssert.AreEqualIgnoringCase(string.Empty, await fizzBuzzWordService.GetWord(1057));
        }

        /// <summary>
        /// Should the fizz buzz word service throw argument exception for the input of zero.
        /// </summary>
        [Test]
        public void Should_FizzBuzzWordService_Throw_ArgumentException_For_Input_Zero()
        {
            var fizzBuzzWordService = new FizzBuzzWordService();

            var exception = Assert.ThrowsAsync<ArgumentException>(async () => await fizzBuzzWordService.GetWord(0));
            Assert.That<string>(exception.Message, Is.EqualTo(ArgumentExceptionMessage));
        }

        /// <summary>
        /// Should the fizz buzz word service throw argument exception for input of negative numbers.
        /// </summary>
        [Test]
        public void Should_FizzBuzzWordService_Throw_ArgumentException_For_Input_Negative_Numbers()
        {
            var fizzBuzzWordService = new FizzBuzzWordService();

            var exception = Assert.ThrowsAsync<ArgumentException>(async () => await fizzBuzzWordService.GetWord(-1));
            Assert.That<string>(exception.Message, Is.EqualTo(ArgumentExceptionMessage));

            exception = Assert.ThrowsAsync<ArgumentException>(async () => await fizzBuzzWordService.GetWord(-15));
            Assert.That<string>(exception.Message, Is.EqualTo(ArgumentExceptionMessage));

            exception = Assert.ThrowsAsync<ArgumentException>(async () => await fizzBuzzWordService.GetWord(-25));
            Assert.That<string>(exception.Message, Is.EqualTo(ArgumentExceptionMessage));
        }
    }
}
