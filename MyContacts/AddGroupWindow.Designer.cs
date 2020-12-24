
namespace MyContacts
{
    partial class AddGroupWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_GoupName = new System.Windows.Forms.TextBox();
            this.BT_AddGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du groupe :";
            // 
            // TB_GoupName
            // 
            this.TB_GoupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GoupName.Location = new System.Drawing.Point(16, 36);
            this.TB_GoupName.Name = "TB_GoupName";
            this.TB_GoupName.Size = new System.Drawing.Size(460, 29);
            this.TB_GoupName.TabIndex = 1;
            // 
            // BT_AddGroup
            // 
            this.BT_AddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddGroup.Location = new System.Drawing.Point(49, 86);
            this.BT_AddGroup.Name = "BT_AddGroup";
            this.BT_AddGroup.Size = new System.Drawing.Size(383, 33);
            this.BT_AddGroup.TabIndex = 2;
            this.BT_AddGroup.Text = "Ajouter un groupe";
            this.BT_AddGroup.UseVisualStyleBackColor = true;
            this.BT_AddGroup.Click += new System.EventHandler(this.BT_AddGroup_Click);
            // 
            // AddGroupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 129);
            this.Controls.Add(this.BT_AddGroup);
            this.Controls.Add(this.TB_GoupName);
            this.Controls.Add(this.label1);
            this.Name = "AddGroupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un groupe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_GoupName;
        private System.Windows.Forms.Button BT_AddGroup;
    }
}