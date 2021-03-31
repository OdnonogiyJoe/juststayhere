using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Savanna
{
    public class MainVM 
    {
        public string[] TypeOfSearch { get; set; }

        ContactsDB contactsDB;
        public List ListViewItem { get; set; }

        public MainVM()
        {
            contactsDB = new ContactsDB();
            TypeOfSearch = new string[] { "По имени", "По телефону" };
        }

        public void ShowContacts(List<Contact> contacts)

        {
            contacts.Clear();
            List<Contact> list = new List<Contact>();
            for (int i = 0; i < list.Count; i++)
            {
                Contact contact = (Contact)list[i];
                contacts.Add(contact);
            }

        }
    }
}
