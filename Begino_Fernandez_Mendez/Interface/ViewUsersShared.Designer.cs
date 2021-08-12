
namespace Interface
{
    partial class ViewUsersShared
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUsersShared = new System.Windows.Forms.Panel();
            this.listUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panelUsersShared.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsersShared
            // 
            this.panelUsersShared.Controls.Add(this.button1);
            this.panelUsersShared.Controls.Add(this.listUsers);
            this.panelUsersShared.Location = new System.Drawing.Point(6, 5);
            this.panelUsersShared.Name = "panelUsersShared";
            this.panelUsersShared.Size = new System.Drawing.Size(545, 426);
            this.panelUsersShared.TabIndex = 0;
            // 
            // listUsers
            // 
            this.listUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listUsers.HideSelection = false;
            this.listUsers.Location = new System.Drawing.Point(124, 100);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(364, 217);
            this.listUsers.TabIndex = 0;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contraseña compartida con:";
            this.columnHeader1.Width = 208;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewUsersShared
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUsersShared);
            this.Name = "ViewUsersShared";
            this.Size = new System.Drawing.Size(552, 432);
            this.panelUsersShared.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsersShared;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
