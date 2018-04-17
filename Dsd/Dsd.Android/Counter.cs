using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Dsd.Droid;
using Xamarin.Forms;
using Dsd;
[assembly: Dependency(typeof(Counter))]

namespace Dsd.Droid
{
  
    public class Counter :ICounter
    {
        int currentCount;
        public int CurrentCount
        {
            get { return currentCount; }
            set
            {
                currentCount = value;
            }
        }
        public void Aumentar()
        {
            CurrentCount = CurrentCount + 1;
        }

    }
}