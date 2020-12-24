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
    public partial class AddGroupWindow : Form
    {
        //Properties
        public Group GroupToAdd { get; private set; }

        //Constructor
        public AddGroupWindow()
        {
            InitializeComponent();
        }

        // Créer un nouveau groupe et ferme la fenêtre en envoyant un DialogResult égal à "OK"
        private void BT_AddGroup_Click(object sender, EventArgs e)
        {
            string groupName = this.TB_GoupName.Text;
            if(groupName.Length > 0)
            {
                this.GroupToAdd = new Group(groupName);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
