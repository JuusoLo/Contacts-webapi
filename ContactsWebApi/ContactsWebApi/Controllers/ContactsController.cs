﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContactsWebApi.Services;
using Microsoft.AspNetCore.Authorization;

namespace ContactsWebApi.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        // GET api/contacts
        [HttpGet]
        public IActionResult Get()
        {
            List<Contact> contacts = _contactService.GetContacts(); 
            return new JsonResult(contacts);
        }

        // GET api/contacts/id
        [HttpGet ("{id}")]
        public IActionResult Get(int id)
        {
            Contact contact = _contactService.GetContactsById(id);
            return new JsonResult(contact);
        }

        // POST api/contacts
        [HttpPost]
        public IActionResult Create([FromBody] Contact contact)
        {
            Contact createdContact = _contactService.CreateContact(contact);
            return new JsonResult(createdContact);
        }

        // PUT api/contacts/{id}
        [HttpPut ("{id}")]
        public IActionResult Update(int id, [FromBody] Contact contact)
        {
            Contact updatedContact = _contactService.UpdateContact(id, contact);
            return new JsonResult(updatedContact);
        }
        // DELETE api/contacts/{id}
        [HttpDelete ("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.DeleteContact(id);
            return new OkResult();
        }
    }

}