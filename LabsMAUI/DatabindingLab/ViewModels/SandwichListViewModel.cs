using Sandwiches.Models;
using System.Collections.ObjectModel;

namespace Sandwiches.ViewModels
{
    public class SandwichListViewModel : BaseViewModel
    {
        private Sandwich current = new Sandwich();
        public Sandwich Current
        {
            get => this.current;
            set => SetProperty(ref this.current, value);
        }
        public SandwichListViewModel()
        {
            var choices = new SandwichTypes();
            Sandwiches = new ObservableCollection<Sandwich>
      {
        new Sandwich
        {
          Id = 1,
          Name = choices[0]
        },
        new Sandwich
        {
          Id = 2,
          Name = choices[1]
        },
      };
        }

        public ObservableCollection<Sandwich> Sandwiches { get; }

        private bool _showList = true;
        private bool _showDetail = false;

        public bool ShowList
        {
            get => this._showList;
            set => SetProperty(ref this._showList, value);
        }

        public bool ShowDetail
        {
            get => this._showDetail;
            set => SetProperty(ref this._showDetail, value);
        }

        public void ShowSandwichList()
        {
            ShowList = true;
            ShowDetail = false;
        }

        public void ShowSandwichDetail()
        {
            ShowList = false;
            ShowDetail = true;
        }

        public void AddNewSandwich() 
        {
            Current = new Sandwich();
            ShowSandwichDetail();
        }

        public void AddSandwich()
        {
            Current.Id = Sandwiches.Max(s => s.Id) + 1;
            Sandwiches.Add(Current);
            ShowSandwichList();
        }
    }
}
