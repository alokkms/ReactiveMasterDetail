using System;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;

namespace ReactiveMasterDetail
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; protected set; }

        public AppBootstrapper()
        {
            Router = new RoutingState();
            RegisterScreen();
            RegisterViews();
            RegisterViewModels();
            this.Router.NavigateAndReset.Execute(new MasterViewModel()).Subscribe();
        }

        public Page CreateMainPage() => new RoutedViewHost();

        private void RegisterScreen()
        {
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
        }

        private void RegisterViewModels()
        {
            Locator.CurrentMutable.Register(() => new ThingOneViewModel());
            Locator.CurrentMutable.Register(() => new ThingTwoViewModel());
        }

        private void RegisterViews()
        {
            Locator.CurrentMutable.Register(() => new MasterPage(), typeof(IViewFor<MasterViewModel>));
            Locator.CurrentMutable.Register(() => new ThingOnePage(), typeof(IViewFor<ThingOneViewModel>));
            Locator.CurrentMutable.Register(() => new ThingTwoPage(), typeof(IViewFor<ThingTwoViewModel>));
        }
    }
}