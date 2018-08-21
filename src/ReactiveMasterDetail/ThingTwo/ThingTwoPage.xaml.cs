using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;

namespace ReactiveMasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThingTwoPage : ReactiveContentPage<ThingTwoViewModel>
    {
        public ThingTwoPage()
        {
            InitializeComponent();
        }
    }
}