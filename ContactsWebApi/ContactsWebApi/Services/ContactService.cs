using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using ContactsWebApi.Repositories;

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
    }
}
