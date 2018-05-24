using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactsWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        public ContactsController()
        {

        }
        // GET api/contacts
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new {firstName = "Mock", lastName = "Object"});
        }

        // GET api/contacts/id
        [HttpGet ("{id}")]
        public IActionResult Get(int id)
        {
            return new OkResult();
        }
    }
}