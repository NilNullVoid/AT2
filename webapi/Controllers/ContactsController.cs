using Microsoft.AspNetCore.Mvc;
using contactsLib;

namespace webapi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    Contacts contacts = new Contacts();
    // api/Contacts
    [HttpGet]
    public IEnumerable<string> Get()
    {
        ContactsTest contactsTest = new ContactsTest();
        contactsTest.add_records(contacts);
        List<string> en = contacts.get_list_str();
        IEnumerable<string> en2 = en as IEnumerable<string>;
        return en;
    }
    // api/Contacts/4  - gets the fourth record if it exists
    [HttpGet(template:"{id}")]
    public string Get(int id)
    {
       // TODO get the id record
       //   and return as a string
    }
}