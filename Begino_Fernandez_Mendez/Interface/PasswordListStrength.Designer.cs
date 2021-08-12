
namespace Interface
{
    partial class PasswordListStrength
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
            this.panelStrength = new System.Windows.Forms.Panel();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.listPasswords = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelStrength.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStrength
            // 
            this.panelStrength.Controls.Add(this.button1);
            this.panelStrength.Controls.Add(this.btnUpdatePass);
            this.panelStrength.Controls.Add(this.listPasswords);
            this.panelStrength.Location = new System.Drawing.Point(0, 0);
            this.panelStrength.Name = "panelStrength";
            this.panelStrength.Size = new System.Drawing.Size(677, 494);
            this.panelStrength.TabIndex = 1;
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUpdatePass.Location = new System.Drawing.Point(302, 281);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(129, 23);
            this.btnUpdatePass.TabIndex = 9;
            this.btnUpdatePass.Text = "Actualizar contraseña";
            this.btnUpdatePass.UseVisualStyleBackColor = false;
            this.btnUpdatePass.Click += new System.EventHandler(this.BtnUpdatePass_Click);
            // 
            // listPasswords
            // 
            this.listPasswords.FormattingEnabled = true;
            this.listPasswords.Location = new System.Drawing.Point(178, 36);
            this.listPasswords.Name = "listPasswords";
            this.listPasswords.Size = new System.Drawing.Size(394, 225);
            this.listPasswords.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordListStrength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStrength);
            this.Name = "PasswordListStrength";
            this.Size = new System.Drawing.Size(677, 494);
            this.panelStrength.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStrength;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.ListBox listPasswords;
        private System.Windows.Forms.Button button1;
    }
}
