using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LabMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMVVM.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class ListContactsViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Models.Contact> contacts;

        [ObservableProperty]
        private bool isBusy;

        [RelayCommand]
        private async Task LoadContactAsync()
        {
            isBusy = true;
            var list = await ContactRepository.GetAllAsync();
            Contacts = new ObservableCollection<Models.Contact>(list);
            isBusy= false;
        }
    }
}
