using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace ReactiveMasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ReactiveMasterDetailPage<MasterViewModel>
    {
        public MasterPage(MasterViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }
    }
}