namespace MyContacts
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PNL_Left = new System.Windows.Forms.Panel();
            this.Group_Search = new System.Windows.Forms.GroupBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.Group_ContactsList = new System.Windows.Forms.GroupBox();
            this.BT_AddContact = new System.Windows.Forms.Button();
            this.LB_Contacts = new System.Windows.Forms.ListBox();
            this.CB_Groups = new System.Windows.Forms.ComboBox();
            this.PNL_Right = new System.Windows.Forms.Panel();
            this.BT_DeleteContact = new System.Windows.Forms.Button();
            this.LB_City = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Tel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_Group = new System.Windows.Forms.Label();
            this.PB_ContactPhoto = new System.Windows.Forms.PictureBox();
            this.PNL_Left.SuspendLayout();
            this.Group_Search.SuspendLayout();
            this.Group_ContactsList.SuspendLayout();
            this.PNL_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ContactPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Left
            // 
            this.PNL_Left.Controls.Add(this.Group_Search);
            this.PNL_Left.Controls.Add(this.Group_ContactsList);
            this.PNL_Left.Location = new System.Drawing.Point(3, 2);
            this.PNL_Left.Name = "PNL_Left";
            this.PNL_Left.Size = new System.Drawing.Size(227, 433);
            this.PNL_Left.TabIndex = 0;
            // 
            // Group_Search
            // 
            this.Group_Search.Controls.Add(this.TB_Search);
            this.Group_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Search.Location = new System.Drawing.Point(0, 379);
            this.Group_Search.Name = "Group_Search";
            this.Group_Search.Size = new System.Drawing.Size(224, 51);
            this.Group_Search.TabIndex = 1;
            this.Group_Search.TabStop = false;
            this.Group_Search.Text = "Rechercher :";
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(6, 22);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(212, 26);
            this.TB_Search.TabIndex = 0;
            // 
            // Group_ContactsList
            // 
            this.Group_ContactsList.Controls.Add(this.BT_AddContact);
            this.Group_ContactsList.Controls.Add(this.LB_Contacts);
            this.Group_ContactsList.Controls.Add(this.CB_Groups);
            this.Group_ContactsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_ContactsList.Location = new System.Drawing.Point(3, 10);
            this.Group_ContactsList.Name = "Group_ContactsList";
            this.Group_ContactsList.Size = new System.Drawing.Size(221, 362);
            this.Group_ContactsList.TabIndex = 0;
            this.Group_ContactsList.TabStop = false;
            this.Group_ContactsList.Text = "Mes contacts";
            // 
            // BT_AddContact
            // 
            this.BT_AddContact.Location = new System.Drawing.Point(19, 330);
            this.BT_AddContact.Name = "BT_AddContact";
            this.BT_AddContact.Size = new System.Drawing.Size(180, 26);
            this.BT_AddContact.TabIndex = 2;
            this.BT_AddContact.Text = "Ajouter";
            this.BT_AddContact.UseVisualStyleBackColor = true;
            this.BT_AddContact.Click += new System.EventHandler(this.BT_AddContact_Click);
            // 
            // LB_Contacts
            // 
            this.LB_Contacts.FormattingEnabled = true;
            this.LB_Contacts.ItemHeight = 20;
            this.LB_Contacts.Location = new System.Drawing.Point(0, 59);
            this.LB_Contacts.Name = "LB_Contacts";
            this.LB_Contacts.Size = new System.Drawing.Size(221, 264);
            this.LB_Contacts.Sorted = true;
            this.LB_Contacts.TabIndex = 1;
            this.LB_Contacts.SelectedIndexChanged += new System.EventHandler(this.LB_Contacts_SelectedIndexChanged);
            // 
            // CB_Groups
            // 
            this.CB_Groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Groups.FormattingEnabled = true;
            this.CB_Groups.Location = new System.Drawing.Point(6, 25);
            this.CB_Groups.Name = "CB_Groups";
            this.CB_Groups.Size = new System.Drawing.Size(209, 28);
            this.CB_Groups.TabIndex = 0;
            this.CB_Groups.SelectedIndexChanged += new System.EventHandler(this.CB_Groups_SelectedIndexChanged);
            // 
            // PNL_Right
            // 
            this.PNL_Right.Controls.Add(this.BT_DeleteContact);
            this.PNL_Right.Controls.Add(this.LB_City);
            this.PNL_Right.Controls.Add(this.label6);
            this.PNL_Right.Controls.Add(this.LB_Address);
            this.PNL_Right.Controls.Add(this.label5);
            this.PNL_Right.Controls.Add(this.LB_Tel);
            this.PNL_Right.Controls.Add(this.label4);
            this.PNL_Right.Controls.Add(this.Lb_Email);
            this.PNL_Right.Controls.Add(this.label1);
            this.PNL_Right.Controls.Add(this.LB_Name);
            this.PNL_Right.Controls.Add(this.LB_Group);
            this.PNL_Right.Controls.Add(this.PB_ContactPhoto);
            this.PNL_Right.Location = new System.Drawing.Point(234, 2);
            this.PNL_Right.Name = "PNL_Right";
            this.PNL_Right.Size = new System.Drawing.Size(302, 433);
            this.PNL_Right.TabIndex = 1;
            // 
            // BT_DeleteContact
            // 
            this.BT_DeleteContact.BackColor = System.Drawing.Color.Transparent;
            this.BT_DeleteContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_DeleteContact.BackgroundImage")));
            this.BT_DeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_DeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DeleteContact.Location = new System.Drawing.Point(267, 3);
            this.BT_DeleteContact.Name = "BT_DeleteContact";
            this.BT_DeleteContact.Size = new System.Drawing.Size(32, 32);
            this.BT_DeleteContact.TabIndex = 18;
            this.BT_DeleteContact.UseVisualStyleBackColor = false;
            // 
            // LB_City
            // 
            this.LB_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_City.Location = new System.Drawing.Point(89, 401);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(204, 20);
            this.LB_City.TabIndex = 17;
            this.LB_City.Text = "Paris";
            this.LB_City.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ville :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Address
            // 
            this.LB_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Address.Location = new System.Drawing.Point(84, 367);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(209, 20);
            this.LB_Address.TabIndex = 15;
            this.LB_Address.Text = "1 rue DeCherPasQuoi";
            this.LB_Address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adresse :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Tel
            // 
            this.LB_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tel.Location = new System.Drawing.Point(89, 331);
            this.LB_Tel.Name = "LB_Tel";
            this.LB_Tel.Size = new System.Drawing.Size(204, 20);
            this.LB_Tel.TabIndex = 13;
            this.LB_Tel.Text = "06 xx xx xx xx";
            this.LB_Tel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tél :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_Email
            // 
            this.Lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Email.Location = new System.Drawing.Point(81, 294);
            this.Lb_Email.Name = "Lb_Email";
            this.Lb_Email.Size = new System.Drawing.Size(214, 23);
            this.Lb_Email.TabIndex = 11;
            this.Lb_Email.Text = "adman.software@gmail.com";
            this.Lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Name
            // 
            this.LB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(2, 235);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(291, 23);
            this.LB_Name.TabIndex = 2;
            this.LB_Name.Text = "Nom Prénom";
            this.LB_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Group
            // 
            this.LB_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Group.Location = new System.Drawing.Point(167, 208);
            this.LB_Group.Name = "LB_Group";
            this.LB_Group.Size = new System.Drawing.Size(130, 23);
            this.LB_Group.TabIndex = 1;
            this.LB_Group.Text = "Groupe";
            this.LB_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PB_ContactPhoto
            // 
            this.PB_ContactPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_ContactPhoto.Image = ((System.Drawing.Image)(resources.GetObject("PB_ContactPhoto.Image")));
            this.PB_ContactPhoto.Location = new System.Drawing.Point(3, 3);
            this.PB_ContactPhoto.Name = "PB_ContactPhoto";
            this.PB_ContactPhoto.Size = new System.Drawing.Size(296, 229);
            this.PB_ContactPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_ContactPhoto.TabIndex = 0;
            this.PB_ContactPhoto.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 446);
            this.Controls.Add(this.PNL_Right);
            this.Controls.Add(this.PNL_Left);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyContacts";
            this.PNL_Left.ResumeLayout(false);
            this.Group_Search.ResumeLayout(false);
            this.Group_Search.PerformLayout();
            this.Group_ContactsList.ResumeLayout(false);
            this.PNL_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_ContactPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Left;
        private System.Windows.Forms.GroupBox Group_ContactsList;
        private System.Windows.Forms.ComboBox CB_Groups;
        private System.Windows.Forms.GroupBox Group_Search;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BT_AddContact;
        private System.Windows.Forms.ListBox LB_Contacts;
        private System.Windows.Forms.Panel PNL_Right;
        private System.Windows.Forms.Label LB_Group;
        private System.Windows.Forms.PictureBox PB_ContactPhoto;
        private System.Windows.Forms.Label LB_City;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_Tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Button BT_DeleteContact;
    }
}

