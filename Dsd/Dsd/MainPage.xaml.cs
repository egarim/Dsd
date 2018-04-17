using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dsd
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var ICounter1 = Xamarin.Forms.DependencyService.Get<ICounter>();
            Debug.WriteLine(string.Format("{0}:{1}", " ICounter1.CurrentCount", ICounter1.CurrentCount));
            ICounter1.Aumentar();
            ICounter1.Aumentar();
            ICounter1.Aumentar();
            ICounter1.Aumentar();
            Debug.WriteLine(string.Format("{0}:{1}", " ICounter1.CurrentCount", ICounter1.CurrentCount));


            var ICounter2 = Xamarin.Forms.DependencyService.Get<ICounter>(DependencyFetchTarget.NewInstance);
            Debug.WriteLine(string.Format("{0}:{1}", " ICounter2.CurrentCount", ICounter2.CurrentCount));

            var ICounter3 = Xamarin.Forms.DependencyService.Get<ICounter>(DependencyFetchTarget.GlobalInstance);

            Debug.WriteLine(string.Format("{0}:{1}", " ICounter3.CurrentCount", ICounter3.CurrentCount));
        }
    }
}
