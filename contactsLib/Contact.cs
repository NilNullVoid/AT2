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
        public int phoneNumber { get; set; }
        public Contact(int cid, string name, int phoneNumber)
        {
            this.cid = cid;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
    }

    public class Contacts
    {
        List<Contact> arr = new List<Contact>();
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
                arrString.Add($"{contact.cid}:{contact.name}:{contact.phoneNumber}");
            }
            return arrString;
        }
        public string search(int cid)
        {
            int i = arr.FindIndex(contact => contact.cid == cid);
            return $"{convertList()[i]} at place {i}";
        }
    }
}
