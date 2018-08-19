using System.Reactive.Disposables;
using ReactiveUI;
using Splat;

namespace ReactiveMasterDetail
{
    public abstract class BaseViewModel : ReactiveObject, IRoutableViewModel
    {
        protected CompositeDisposable SubscriptionDisposables = new CompositeDisposable();

        public IScreen HostScreen { get; }

        public string UrlPathSegment { get; }

        protected BaseViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
        }
    }
}