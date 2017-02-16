//-----------------------------------------------------------------------
// <copyright file="FizzBuzzWordService.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Core;

    /// <summary>
    /// Fuzz Buzz word service
    /// </summary>
    public class FizzBuzzWordService : INumberToWordService
    {
        /// <summary>
        /// The dictionary
        /// </summary>
        private Dictionary<int, string> dictionary = new Dictionary<int, string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzWordService"/> class.
        /// </summary>
        public FizzBuzzWordService()
        {
            this.dictionary.Add(3, "Fizz");
            this.dictionary.Add(5, "Buzz");
        }

        /// <summary>
        /// Gets the fizz or buzz word based on the input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the word</returns>
        public async Task<string> GetWord(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentException("The value should be a non zero and non-negative number.");
            }

            // async capability
            return await Task.Run<string>(delegate
            {
                string word = string.Empty;
                if (input % 3 == 0)
                {
                    word = this.dictionary[3];
                }
                else if (input % 5 == 0)
                {
                    word = this.dictionary[5];
                }

                return word;
            }).ConfigureAwait(false);
        }
    }
}
