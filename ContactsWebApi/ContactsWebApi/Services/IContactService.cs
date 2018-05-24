using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;

namespace ContactsWebApi.Services
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        Contact GetContactsById(int id);
        Contact CreateContact(Contact contact);
        Contact UpdateContact(int id, Contact contact);
        void DeleteContact(int id);
    }
}
