using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using Splat;
using Xamarin.Forms;

namespace ReactiveMasterDetail
{
    public static class SignalExtension
    {
        public static IObservable<Unit> ToSignal<T>(this IObservable<T> @this)
        {
            if (@this == null)

            {
                throw new ArgumentNullException(nameof(@this));
            }

            return @this

                .Select(_ => Unit.Default);
        }
    }

    public class MasterViewModel : BaseViewModel
    {
        public ReactiveCommand<MasterPageItem, Unit> ItemTappedCommand { get; set; }

        public EventHandler<SelectedItemChangedEventArgs> SelectedItem { get; set; }

        public MasterViewModel()
        {
            SetupReactiveSubscription();
            SetupReactiveObservables();
        }

        private static IRoutableViewModel GetViewModel(MasterPageItem item)
        {
            return (IRoutableViewModel)Locator.Current.GetService(item.TargetType);
        }

        private IObservable<Unit> ExecuteItemSelectedCommand(MasterPageItem item) 
            => HostScreen.Router.NavigateAndReset.Execute(GetViewModel(item)).ToSignal();

        private void SetupReactiveObservables()
        {
            ItemTappedCommand =
                ReactiveCommand.CreateFromObservable<MasterPageItem, Unit>(ExecuteItemSelectedCommand);
        }

        private void SetupReactiveSubscription()
        {
        }
    }
}