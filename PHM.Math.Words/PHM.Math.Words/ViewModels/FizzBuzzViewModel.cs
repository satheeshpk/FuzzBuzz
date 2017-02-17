//-----------------------------------------------------------------------
// <copyright file="FizzBuzzViewModel.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Services.Factory;
    using Xamarin.Forms;

    /// <summary>
    /// Fizz Buzz View Model
    /// </summary>
    /// <seealso cref="INotifyPropertyChanged" />
    public class FizzBuzzViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The fizz buzz result
        /// </summary>
        private string fizzBuzzResult = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzViewModel"/> class.
        /// </summary>
        public FizzBuzzViewModel()
        {
#pragma warning disable RECS0165 // Asynchronous methods should return a Task instead of void
            this.FizzBuzz = new Command(async (task) => await this.BindResult());
#pragma warning restore RECS0165 // Asynchronous methods should return a Task instead of void
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int? Number
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the fizz buzz result.
        /// </summary>
        /// <value>
        /// The fizz buzz result.
        /// </value>
        public string FizzBuzzResult
        {
            get
            {
                return this.fizzBuzzResult;
            }

            protected set
            {
                this.fizzBuzzResult = value;
                this.OnPropertyChanged("FizzBuzzResult");
            }
        }

        /// <summary>
        /// Gets or sets the fizz buzz command.
        /// </summary>
        /// <value>
        /// The fizz buzz command.
        /// </value>
        public ICommand FizzBuzz
        {
            get;
            protected set;
        }

        /// <summary>
        /// Called when the view model property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Binds the fizz buzz result.
        /// </summary>
        /// <returns>the awaiting task</returns>
        private async Task BindResult()
        {
            if (this.Number.HasValue)
            {
                var wordService = new WordServiceFactory().GetNumberWordService("FizzBuzz");
                try
                {
                    this.FizzBuzzResult = await wordService.GetWord(this.Number.Value);
                }
                catch (ArgumentException)
                {
                    this.FizzBuzzResult = string.Empty;
                }
            }
            else
            {
                this.FizzBuzzResult = string.Empty;
            }
        }
    }
}
