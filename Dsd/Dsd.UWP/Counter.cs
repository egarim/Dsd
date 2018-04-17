using Dsd.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Dsd;
[assembly: Dependency(typeof(Counter))]

namespace Dsd.UWP
{
    public class Counter:ICounter
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
