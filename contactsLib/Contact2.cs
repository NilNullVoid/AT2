using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace contactsLib2
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
        private async Task<string> MakeApiRequest(string url)
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            return response;
        }
        private string ApiServer = "localhost:80";
        public string add(Contact c)
        {
            string url = $"http://{ApiServer}/api/add.php?contact={c.cid},{c.name},{c.phoneNumber}";
            return MakeApiRequest(url).Result;
        }

        public string delete(int cid)
        {
            string url = $"http://{ApiServer}/api/delete.php?cid={cid}";
            return MakeApiRequest(url).Result;
        }

        /*public List<string> convertList()
        {
            List<string> arrString = new List<string>();
            foreach (Contact contact in arr)
            {
                arrString.Add($"{contact.cid}:{contact.name}:{contact.phoneNumber}");
            }
            return arrString;
        }*/
        public string search(int cid)
        {
            string url = $"http://{ApiServer}/api/search.php?cid={cid}";
            return MakeApiRequest(url).Result;
        }
    }
}
