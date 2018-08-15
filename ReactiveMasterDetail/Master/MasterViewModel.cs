using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using Xamarin.Forms;

namespace ReactiveMasterDetail
{
    public class MasterViewModel : BaseViewModel
    {
        private IObservable<EventPattern<SelectedItemChangedEventArgs>> _selectedItemdChanged;

        public ReactiveCommand<Unit, Unit> ItemSelectedCommand { get; set; }

        public EventHandler<SelectedItemChangedEventArgs> SelectedItem { get; set; }

        public MasterViewModel()
        {
            SetupReactiveSubscription();
            SetupReactiveObservables();
        }

        private void ExecuteItemSelectedCommand()
        {
            HostScreen.Router.Navigate.Execute(new ThingOneViewModel());
        }

        private void SetupReactiveObservables()
        {
            ItemSelectedCommand = ReactiveCommand.Create(ExecuteItemSelectedCommand);
        }

        private void SetupReactiveSubscription()
        {
            _selectedItemdChanged = Observable.FromEventPattern<SelectedItemChangedEventArgs>(x => SelectedItem += x, x => SelectedItem -= x);
            _selectedItemdChanged.Select(x => x.EventArgs).Subscribe(@event => { });
        }
    }
}