using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LabMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMVVM.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class EditContactViewModel
    {

        private Models.Contact contact;

        [ObservableProperty]
        private int? contactId;

        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private string lastName;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private bool isBusy;

        partial void OnContactIdChanged(int? value)
        {
            LoadContactAsync();
        }

        private async void LoadContactAsync()
        {
            isBusy = true;
            if (ContactId.HasValue)
            {
                contact = await ContactRepository.GetAsync(ContactId.Value);
                FirstName = contact.FirstName;
                LastName = contact.LastName;
                Email = contact.Email;
            }
            isBusy = false;
        }
        [RelayCommand]
        private async Task SaveContactAsync()
        {
            isBusy = true;
            if (contact == null) return;
            contact.FirstName = FirstName;
            contact.LastName = LastName;
            contact.Email = Email;
            await ContactRepository.SaveAsync(contact);
            IsBusy = false;
        }
    }
}
