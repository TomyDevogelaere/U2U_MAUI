using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sandwiches.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        // public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        private bool isBusy = false;
        public bool IsBusy
        {
            get => this.isBusy;
            set => SetProperty(ref this.isBusy, value);
        }

        private string title = string.Empty;
        public string Title
        {
            get => this.title;
            set => SetProperty(ref this.title, value);
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                return false;
            }

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
          => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
