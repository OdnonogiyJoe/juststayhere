using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class MainVM : MainWindow
    {
        ContactsDB contactsDB;
        public MainVM()
        {
            //ComboBox.Items.Add("убирай");
            ContactsDB contactsDB = new ContactsDB();
            // 2) заполнение выпадющего списка (combobox) не сделано
        }
        public void ShowContacts(List<Contact> contacts)
        {
            contacts.Clear();//1
            List<Contact> list = new List<Contact>();//криво 2 
            for (int i = 0; i < list.Count; i++)
            {
                Contact contact = (Contact)list[i];
                contacts.Add(contact);

            }

        }
    }
}
