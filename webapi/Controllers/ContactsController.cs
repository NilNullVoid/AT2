using Microsoft.AspNetCore.Mvc;
using contactsLib2;
using ContactsTest;

namespace webapi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    ContactTest test = new ContactTest();
    ContactsLink link = new ContactsLink();
    // api/Contacts
    [HttpGet]
    public string Get()
    {
        return link.get().list();
    }
    // api/Contacts/4  - gets the fourth record if it exists
    [HttpGet("{id}")]
    public string Get(int id)
    {
        
        return link.get().search(id);
    }
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        link.get().delete(id);
        return $"Successfully deleted record {id}";
    }
    [HttpPost]
    public string Post(Contact contact)
    {
        link.get().add(contact);
        return $"Created record : {contact.cid}:{contact.name}:{contact.phoneNumber}";
    }
}
