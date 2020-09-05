using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyContacts
{
    public partial class AddContactWindow : Form
    {

        //Constructor
        public AddContactWindow()
        {
            InitializeComponent();

            LoadGroup();
        }

        // Charge les groupes dans la liste déroulante
        private void LoadGroup()
        {
            this.CB_Group.Items.Clear();
            this.CB_Group.Items.AddRange(Global.contactsGroup.ToArray());

            if(this.CB_Group.Items.Count > 0)
            {
                this.CB_Group.SelectedIndex = 0;
            }
        }

        //Création d'un nouveau contact lors d'un clic sur le bouton "Ajouter"
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
            {// Sinon on affiche un message "d'erreur"
                MessageBox.Show("Veuillez entrer tous les champs !", "MyContact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Vérifie si les saisies sont corrects
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

        // Permet de choisir et afficher la photo du contact
        private void BT_ChooseImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.OFD.ShowDialog();
            if(dr == DialogResult.OK)
            {
                this.PB_ContactPhoto.ImageLocation = this.OFD.FileName;
            }
        }
    }
}
