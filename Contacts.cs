using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ContactsForm : Form
    {
        List<Person> contactBook = new List<Person>();

        public ContactsForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                Age = Convert.ToInt32(textBoxAge.Text),
                Mobile = textBoxMobile.Text,
                TypeEnum = (Person.Type)comboBoxType.SelectedItem
            };
            contactBook.Add(newPerson);
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            ListContacts listContacts = new ListContacts();
            listContacts.ShowDialog();
            foreach (Person onePerson in contactBook)
            {
                listContacts.label6.Text = onePerson.ToString();
            }
        }
    }
}
