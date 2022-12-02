using System;
using Xunit;
using contactsLib;

namespace ContactsTest
{
    public class ContactTest
    {
        ContactsLink test = new ContactsLink();
        [Theory]
        [InlineData(22, "john", 7774422, "22:john:7774422")]
        [InlineData(34, "jane", 22.2, "34:jane:22")]
        public void testAdd(int cid, string name, int phoneNumber, string expected)
        {   
            Contact testing = new Contact(cid, name, phoneNumber);
            test.get().add(testing);
            Assert.Contains(expected, test.get().convertList());
        }

        [Fact]
        public void testDel()
        {
            while(test.get().convertList().Count < 2) {
                test.get().add(new Contact(1, "1", 1));
            }
            test.get().delete(0);
            test.get().delete(0);
            Assert.Empty(test.get().convertList());
        }
    }
}
; 