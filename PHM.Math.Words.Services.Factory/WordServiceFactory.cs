//-----------------------------------------------------------------------
// <copyright file="WordServiceFactory.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Services.Factory
{   
    using System.Collections.Generic;
    using Core;
    using Services;

    /// <summary>
    /// Word Service Factory
    /// </summary>
    public class WordServiceFactory
    {
        /// <summary>
        /// The number word services
        /// </summary>
        private Dictionary<string, INumberToWordService> numberWordServices = new Dictionary<string, INumberToWordService>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordServiceFactory"/> class.
        /// </summary>
        public WordServiceFactory()
        {
            this.numberWordServices.Add("FizzBuzz", new FizzBuzzWordService());
        }

        /// <summary>
        /// Gets the number word service.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns>the number service</returns>
        /// <exception cref="System.Collections.Generic.KeyNotFoundException">No associated service type was found.</exception>
        public INumberToWordService GetNumberWordService(string serviceType)
        {
            if (!this.numberWordServices.ContainsKey(serviceType))
            {
                throw new KeyNotFoundException("No associated service type was found.");
            }

            return this.numberWordServices[serviceType];
        }
    }
}
