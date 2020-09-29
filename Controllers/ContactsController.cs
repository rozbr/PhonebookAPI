
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using PhonesbookAPI.Models;
using PhonesbookAPI.Services;


namespace PhonesbookAPI.Controllers {
  [Route("api/contacts")]
  [ApiController]
  public class ContactsController : ControllerBase {
    private readonly ContactsService _contactsService;

    public ContactsController(ContactsService service) {
      _contactsService = service;
    }

    [HttpGet]
    public ActionResult<List<Contact>> Get() => _contactsService.Get();

    [HttpGet("{id}", Name="GetContact")]
    public ActionResult<Contact> Get(string id) {
      var contact = _contactsService.Get(id);

      if (contact == null)
        return NotFound();

      return contact;
    }

    [HttpPost]
    public ActionResult<Contact> Create(Contact contact) {
      _contactsService.Create(contact);

      return CreatedAtRoute("GetContact", new { id = contact.Id.ToString() }, contact);
    }

    [HttpPut("{id}")]
    public ActionResult<Contact> Update(string id, Contact contact) {
      var oldContact = _contactsService.Get(id);

      if (oldContact == null)
        return NotFound();

      contact.Id = id;
      _contactsService.Update(id, contact);

      return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(string id) {
      var contact = _contactsService.Get(id);

      if (contact == null)
        return NotFound();

      _contactsService.Delete(id);

      return Ok();
    }
  }
}
