using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyContacts
{
    public partial class AddContactWindow : Form
    {
        public AddContactWindow()
        {
            InitializeComponent();

            LoadGroup();
        }

        private void LoadGroup()
        {
            this.CB_Group.Items.Clear();
            this.CB_Group.Items.AddRange(Global.contactsGroup.ToArray());

            if(this.CB_Group.Items.Count > 0)
            {
                this.CB_Group.SelectedIndex = 0;
            }
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            //Récupérer les champs saisis
            string lastName = this.TB_LastName.Text;
            string firstName = this.TB_FirstName.Text;
            string email = this.TB_Email.Text;
            string tel = this.TB_Tel.Text;
            string address = this.TB_Adress.Text;
            string city = this.TB_City.Text;
            Group group = (Group)this.CB_Group.SelectedItem;
            Image photo = this.PB_ContactPhoto.Image;

            //Vérification des champs
            if(CheckInputs(firstName, lastName, email, tel, address, city, group))
            {
                //Création d'un nouveau contact
                Contact contact = new Contact(firstName, lastName, email, tel, address, city, photo);

                //Ajout du contact dans le groupe
                group.Contacts.Add(contact);

                //Fermer la fenêtre
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Veuillez entrer tous les champs !", "MyContact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckInputs(string firstName, string lastName, string email, string tel, string address, string city, Group group)
        {
            return !string.IsNullOrEmpty(firstName)
                && !string.IsNullOrEmpty(lastName)
                && !string.IsNullOrEmpty(email)
                && !string.IsNullOrEmpty(tel)
                && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(city)
                && group != null;
        }
    }
}
