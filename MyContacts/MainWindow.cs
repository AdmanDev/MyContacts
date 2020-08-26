using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadGroup();
        }

        private void LoadGroup()
        {
            this.CB_Groups.Items.Clear();
            this.CB_Groups.Items.Add("Tout");
            this.CB_Groups.Items.AddRange(Global.contactsGroup.ToArray());

            this.CB_Groups.SelectedIndex = 0;
        }

        private void BT_AddContact_Click(object sender, EventArgs e)
        {
            AddContactWindow acw = new AddContactWindow();
            DialogResult dr = acw.ShowDialog();

           if(dr == DialogResult.OK)
            {
                //Mettre à jour la liste des contacts
            }


        }
    }
}
