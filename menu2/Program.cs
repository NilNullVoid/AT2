using System;
using contactsLib2;

namespace menu
{
    class Program2
    {
        static ContactsLink link = new ContactsLink();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add record\n2. Delete record\n3. Print\n4. Exit");
                switch (Console.ReadKey().Key.ToString())
                {
                    case "D1":
                        Console.Clear();
                        Add();
                        Console.ReadKey();
                        continue;
                    case "D2":
                        Console.Clear();
                        Delete();
                        Console.ReadKey();
                        continue;
                    case "D3":
                        Console.Clear();
                        PrintRecords();
                        Console.ReadKey();
                        continue;
                    case "D4":
                        Console.Clear();
                        Console.WriteLine("Thank you for using the Contacts Test Console.");
                        break;
                    default:
                        continue;
                }
                break;
            }
        }
        static void Add()
        {
            Console.WriteLine("You've selected to add a new record");

            Console.WriteLine("Please enter the CID of the record: ");
            int cid = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Name of the record: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the Phone Number of the record: ");
            int phonenumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(link.get().add(new Contact(cid, name, phonenumber)));
        }
        static void Delete()
        {
            Console.WriteLine("You've selected to delete a record");
            Console.WriteLine("Please enter the position of the record: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine(link.get().delete(x));
        }
        static void PrintRecords()
        {
            Console.WriteLine("position | cid:name:phonenumber");
            /*for (int i = 0; i < link.get().convertList().Count; i++)
            {
                Console.WriteLine($"{i} | {link.get().convertList()[i]}");
            }*/
        }
    }
}
