//-----------------------------------------------------------------------
// <copyright file="IWordService.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Services.Core
{
    using System.Threading.Tasks;

    /// <summary>
    /// Word Service Contract
    /// </summary>
    /// <typeparam name="T">type parameter</typeparam>
    public interface IWordService<T>
    {
        /// <summary>
        /// Gets the word.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the word</returns>
        Task<string> GetWord(T input);
    }
}
