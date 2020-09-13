using System;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class MainWindow : Form
    {
        //Constructor
        public MainWindow()
        {
            InitializeComponent();

            // On ouvre les données (groupes et contacts) de l'utilisateur
            Global.contactsGroup = SaveManager.Open();

            LoadGroup();
        }

        // Charge les groupes dans la liste déroulante
        private void LoadGroup()
        {
            this.CB_Groups.Items.Clear();
            this.CB_Groups.Items.Add("Tout");
            this.CB_Groups.Items.AddRange(Global.contactsGroup.ToArray());

            this.CB_Groups.SelectedIndex = 0;
        }

        // Met à jour la liste de contacts en fonction du groupe séléctionné
        private void UpdateContacts()
        {
            int selectedIndex = this.CB_Groups.SelectedIndex; //Position du groupe sélectionné
            if(selectedIndex == 0)
            {// Afficher tout les contacts (élement "Tout" séléctionné)
                ShowAllContacts();
            }
            else if(selectedIndex > 0)
            {// Afficher les contacts du groupe séléctionné
                Group group = (Group)this.CB_Groups.SelectedItem;
                ShowContactsOf(group);
            }

            if(this.LB_Contacts.Items.Count > 0)
            {// Séléctionner le premier contact de la liste
                this.LB_Contacts.SelectedIndex = 0;
            }
            else
            {// Enlève les infos du contact précédent
                ClearInfos();
            }
        }

        // Affiche, dans la liste, les contacts d'un groupe
        private void ShowContactsOf(Group group)
        {
            this.LB_Contacts.Items.Clear();
            this.LB_Contacts.Items.AddRange(group.Contacts.ToArray());
        }

        // Affiche, dans la liste, tout les contacts
        private void ShowAllContacts()
        {
            this.LB_Contacts.Items.Clear();
            foreach (Group group in Global.contactsGroup)
            {
                this.LB_Contacts.Items.AddRange(group.Contacts.ToArray());
            }
        }

        // Lors d'un clic sur le bouton "Ajouter"...
        private void BT_AddContact_Click(object sender, EventArgs e)
        {
            // Ouverture de la fenêtre d'ajout de contact
            AddContactWindow acw = new AddContactWindow();
            DialogResult dr = acw.ShowDialog();

            // Si l'utilisateur à valider son choix...
           if(dr == DialogResult.OK)
            {
                // Mettre à jour la liste des contacts
                UpdateContacts();

                // Sauvegarder les données
                SaveManager.Save(Global.contactsGroup);
            }
        }

        // Lors d'une nouvelle sélection de groupe (dans la liste déroulante)...
        private void CB_Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mettre à jour la liste des contacts
            UpdateContacts();
        }

        // Lorsqu'un contact est sélectionné, dans la liste de contacts...
        private void LB_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupèration du contact sélectionné
            Contact contact = (Contact)this.LB_Contacts.SelectedItem;

            // Si ce contact n'est pas null...
            if(contact != null)
            {
                // Affichage des information du contact
                ShowInfosOf(contact);
            }
        }

        // Affichage des information d'un contact
        private void ShowInfosOf(Contact contact)
        {
            //On enlève les infos du contact précédant
            ClearInfos();

            // On affiche ceux du nouveau
            this.PB_ContactPhoto.Image = contact.Photo;
            this.LB_Group.Text = this.CB_Groups.SelectedItem.ToString();
            this.LB_Name.Text = contact.ToString();
            this.Lb_Email.Text = contact.Email;
            this.LB_Tel.Text = contact.Tel;
            this.LB_Address.Text = contact.Address;
            this.LB_City.Text = contact.City;
        }

        // Enlève les infos du contact précédemment séléctionné
        private void ClearInfos()
        {
            this.PB_ContactPhoto.Image = null;
            this.LB_Group.Text = "";
            this.LB_Name.Text = "";
            this.Lb_Email.Text = "";
            this.LB_Tel.Text = "";
            this.LB_Address.Text = "";
            this.LB_City.Text = "";
        }
    }
}
