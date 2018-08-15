using System.Reactive.Disposables;
using ReactiveUI;

namespace ReactiveMasterDetail
{
    public abstract class BaseViewModel : ReactiveObject, IRoutableViewModel
    {
        protected CompositeDisposable SubscriptionDisposables = new CompositeDisposable();
        public IScreen HostScreen { get; }
        public string UrlPathSegment { get; }
    }
}