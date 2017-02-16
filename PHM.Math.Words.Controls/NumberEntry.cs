//-----------------------------------------------------------------------
// <copyright file="NumberEntry.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Controls
{
    using Xamarin.Forms;

    /// <summary>
    /// Number entry control
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Entry" />
    public class NumberEntry : Entry
    {
        /// <summary>
        /// The is valid property
        /// </summary>
        public static readonly BindableProperty IsValidProperty =
           BindableProperty.Create("IsValid", typeof(bool), typeof(NumberEntry), false);

        /// <summary>
        /// The number property
        /// </summary>
        public static readonly BindableProperty NumberProperty =
           BindableProperty.Create("Number", typeof(int?), typeof(NumberEntry), null);

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberEntry"/> class.
        /// </summary>
        public NumberEntry()
        {
            this.TextChanged += this.NumberEntry_TextChanged;
        }

        /// <summary>
        /// Gets a value indicating whether the input entry is a valid number.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this input entry is valid; otherwise, <c>false</c>.
        /// </value>
        public bool IsValid
        {
            get
            {
                return (bool)this.GetValue(IsValidProperty);
            }

            private set
            {
                this.SetValue(IsValidProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int? Number
        {
            get
            {
                return (int?)this.GetValue(NumberProperty);
            }

            set
            {
                this.SetValue(NumberProperty, value);
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the NumberEntry control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void NumberEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var numberValue = 0;
            if (!int.TryParse(e.NewTextValue, out numberValue))
            {
                this.IsValid = false;
                this.BackgroundColor = Color.Red;
                this.Number = null;
            }
            else
            {
                this.IsValid = true;
                this.BackgroundColor = Color.White;
                this.Number = numberValue;
            }
        }
    }
}
