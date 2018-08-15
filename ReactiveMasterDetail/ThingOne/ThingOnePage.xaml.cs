using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;

namespace ReactiveMasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThingOnePage : ReactiveContentPage<ThingOneViewModel>
    {
        public ThingOnePage()
        {
            InitializeComponent();
        }
    }
}