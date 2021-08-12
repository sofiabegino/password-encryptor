
namespace Interface
{
    partial class CreateUser
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.txtCreateUserN = new System.Windows.Forms.TextBox();
            this.lblCreateUserN = new System.Windows.Forms.Label();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.lblCreatePass = new System.Windows.Forms.Label();
            this.createUserPanel = new System.Windows.Forms.Panel();
            this.lblUserCreated = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.createUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateUser
            // 
            this.lblCreateUser.AutoSize = true;
            this.lblCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCreateUser.Location = new System.Drawing.Point(239, 42);
            this.lblCreateUser.Name = "lblCreateUser";
            this.lblCreateUser.Size = new System.Drawing.Size(117, 20);
            this.lblCreateUser.TabIndex = 0;
            this.lblCreateUser.Text = "Crear usuario";
            // 
            // txtCreateUserN
            // 
            this.txtCreateUserN.Location = new System.Drawing.Point(209, 116);
            this.txtCreateUserN.Name = "txtCreateUserN";
            this.txtCreateUserN.Size = new System.Drawing.Size(237, 20);
            this.txtCreateUserN.TabIndex = 1;
            // 
            // lblCreateUserN
            // 
            this.lblCreateUserN.AutoSize = true;
            this.lblCreateUserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateUserN.Location = new System.Drawing.Point(120, 120);
            this.lblCreateUserN.Name = "lblCreateUserN";
            this.lblCreateUserN.Size = new System.Drawing.Size(55, 16);
            this.lblCreateUserN.TabIndex = 2;
            this.lblCreateUserN.Text = "Usuario";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(209, 181);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.PasswordChar = '*';
            this.txtCreatePassword.Size = new System.Drawing.Size(237, 20);
            this.txtCreatePassword.TabIndex = 3;
            // 
            // lblCreatePass
            // 
            this.lblCreatePass.AutoSize = true;
            this.lblCreatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePass.Location = new System.Drawing.Point(120, 185);
            this.lblCreatePass.Name = "lblCreatePass";
            this.lblCreatePass.Size = new System.Drawing.Size(77, 16);
            this.lblCreatePass.TabIndex = 4;
            this.lblCreatePass.Text = "Contraseña";
            // 
            // createUserPanel
            // 
            this.createUserPanel.Controls.Add(this.lblUserCreated);
            this.createUserPanel.Controls.Add(this.lblCreatePass);
            this.createUserPanel.Controls.Add(this.btnVolver);
            this.createUserPanel.Controls.Add(this.txtCreatePassword);
            this.createUserPanel.Controls.Add(this.lblCreateUserN);
            this.createUserPanel.Controls.Add(this.btnCreateUser);
            this.createUserPanel.Controls.Add(this.txtCreateUserN);
            this.createUserPanel.Controls.Add(this.lblCreateUser);
            this.createUserPanel.Location = new System.Drawing.Point(0, 0);
            this.createUserPanel.Name = "createUserPanel";
            this.createUserPanel.Size = new System.Drawing.Size(641, 417);
            this.createUserPanel.TabIndex = 5;
            this.createUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createUserPanel_Paint);
            // 
            // lblUserCreated
            // 
            this.lblUserCreated.AutoSize = true;
            this.lblUserCreated.ForeColor = System.Drawing.Color.Red;
            this.lblUserCreated.Location = new System.Drawing.Point(226, 237);
            this.lblUserCreated.Name = "lblUserCreated";
            this.lblUserCreated.Size = new System.Drawing.Size(0, 13);
            this.lblUserCreated.TabIndex = 5;
            this.lblUserCreated.Click += new System.EventHandler(this.lblUserCreated_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnVolver.Location = new System.Drawing.Point(19, 14);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCreateUser.Location = new System.Drawing.Point(243, 266);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(104, 27);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Crear";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createUserPanel);
            this.Name = "CreateUser";
            this.Size = new System.Drawing.Size(641, 417);
            this.createUserPanel.ResumeLayout(false);
            this.createUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.TextBox txtCreateUserN;
        private System.Windows.Forms.Label lblCreateUserN;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Label lblCreatePass;
        private System.Windows.Forms.Panel createUserPanel;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblUserCreated;
    }
}
