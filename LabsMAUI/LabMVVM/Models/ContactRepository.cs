using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMVVM.Models
{
    internal class ContactRepository
    {
        private static List<Contact> Contacts { get; } = new List<Contact>()
        {
            new Contact(){ Id= 1, FirstName="Hank", LastName="Moody", Email="hank.moody@u2u.be"},
            new Contact(){ Id= 2, FirstName="Ted", LastName="Grumpy", Email="ted.grumpy@u2u.be"},
            new Contact(){ Id= 3, FirstName="Frank", LastName="Cranky", Email="frank.cranky@u2u.be"}
        };

        public static async Task<List<Contact>> GetAllAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return Contacts;
        }

        public static async Task<Contact> GetAsync(int ContactId)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return Contacts.SingleOrDefault(c => c.Id == ContactId);
        }

        public static async Task SaveAsync(Contact contact)
        {
             await Task.Delay(TimeSpan.FromSeconds(2));

        }
    }
}
