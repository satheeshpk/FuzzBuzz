//-----------------------------------------------------------------------
// <copyright file="App.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words
{
    using Views;
    using Xamarin.Forms;

    /// <summary>
    /// Main application
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Application" />
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {   
            this.InitializeComponent();

            this.MainPage = new FizzBuzzPage();
        }
    }
}
