
namespace Interface
{
    partial class ViewPasswordsShared
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
            this.panelPasswords = new System.Windows.Forms.Panel();
            this.listPassword = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panelPasswords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPasswords
            // 
            this.panelPasswords.Controls.Add(this.button1);
            this.panelPasswords.Controls.Add(this.listPassword);
            this.panelPasswords.Location = new System.Drawing.Point(5, 9);
            this.panelPasswords.Name = "panelPasswords";
            this.panelPasswords.Size = new System.Drawing.Size(545, 420);
            this.panelPasswords.TabIndex = 0;
            // 
            // listPassword
            // 
            this.listPassword.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listPassword.HideSelection = false;
            this.listPassword.Location = new System.Drawing.Point(108, 87);
            this.listPassword.Name = "listPassword";
            this.listPassword.Size = new System.Drawing.Size(363, 232);
            this.listPassword.TabIndex = 0;
            this.listPassword.UseCompatibleStateImageBehavior = false;
            this.listPassword.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contraseñas Compartidas conmigo:";
            this.columnHeader1.Width = 213;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewPasswordsShared
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPasswords);
            this.Name = "ViewPasswordsShared";
            this.Size = new System.Drawing.Size(551, 430);
            this.panelPasswords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPasswords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listPassword;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
