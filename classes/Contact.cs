using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace contactsLib
{
    public class Contact
    {
        public int cid { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
    }

    public class Contacts
    {
        List<Contact> arr;
        public void add(Contact contact)
        {
            arr.Add(contact);
        }

        public void delete(int index)
        {
            arr.RemoveAt(index);
        }

        public List<string> convertList()
        {
            List<string> arrString = new List<string>();
            foreach (Contact contact in arr)
            {
                arrString.Add(contact.cid + ": " + contact.name + ": " + contact.phoneNumber);
            }
            return arrString;
        }
    }
}
