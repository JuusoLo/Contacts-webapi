using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using ContactsWebApi.Repositories;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ContactsWebApi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public List<Contact> GetContacts()
        {
            return _contactRepository.Get();
        }

        public Contact GetContactsById(int id)
        {
            return _contactRepository.Get(id);
        }

        public Contact UpdateContact(int id, Contact contact)
        {
            var saveContact = _contactRepository.Get(id);
            if (saveContact == null)
            {
                throw new Exception("Contact not found.");
            }
            else
            {
               return _contactRepository.Update(contact);
            }

        }

        public Contact CreateContact(Contact contact)
        {
            return _contactRepository.Create(contact);
        }

        public void DeleteContact(int id)
        {
            _contactRepository.Delete(id);

        }
    }
}
