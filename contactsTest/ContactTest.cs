using System;
using Xunit;
using contactsLib;

namespace ContactsTest
{
    public class ContactTest
    {
        [Theory]
        [InlineData(22, "john", 7774422, "22:john:7774422")]
        [InlineData(34, "jane", 22.2, "34:jane:22")]
        public void testAdd(int cid, string name, int phoneNumber, string expected)
        {
            ContactsLink test = new ContactsLink();
            Contact testing = new Contact(cid, name, phoneNumber);
            test.get().add(testing);
            Assert.Equal(expected, test.get().convertList()[0]);
        }
    }
}
; 