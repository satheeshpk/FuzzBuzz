namespace PHM.Math.Words.Droid.UI.Tests
{
    using System;
    using Xamarin.UITest.Utils;

    public class WaitTimes : IWaitTimes
    {
        public TimeSpan GestureCompletionTimeout
        {
            get
            {
                return TimeSpan.FromMinutes(5);
            }
        }

        public TimeSpan GestureWaitTimeout
        {
            get { return TimeSpan.FromMinutes(5); }
        }
        public TimeSpan WaitForTimeout
        {
            get { return TimeSpan.FromMinutes(5); }
        }
    }
}
