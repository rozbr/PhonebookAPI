
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using PhonesbookAPI.Models;
using PhonesbookAPI.Services;


namespace PhonesbookAPI.Controllers {
  [Route("api/contacts")]
  [ApiController]
  public class ContactsController : ControllerBase {
    private readonly ContactsService _contactService;

    public ContactsController(ContactsService service) {
      _contactService = service;
    }

    [HttpGet]
    public ActionResult<List<Contact>> Get() => new List<Contact>();
  }
}
