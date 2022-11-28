using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactsLib
{
    public class ContactsLink
    {
        static Contacts instance = new Contacts();
        public Contacts get()
        {
            return instance;
        }
        
    }
}
