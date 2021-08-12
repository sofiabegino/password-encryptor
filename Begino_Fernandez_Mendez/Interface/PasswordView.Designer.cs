
namespace Interface
{
    partial class PasswordView
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
            this.components = new System.ComponentModel.Container();
            this.lblPassTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblSitio = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.passwordViewPanel = new System.Windows.Forms.Panel();
            this.txtCategories = new System.Windows.Forms.TextBox();
            this.passwordViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassTitle
            // 
            this.lblPassTitle.AutoSize = true;
            this.lblPassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassTitle.Location = new System.Drawing.Point(242, 28);
            this.lblPassTitle.Name = "lblPassTitle";
            this.lblPassTitle.Size = new System.Drawing.Size(157, 16);
            this.lblPassTitle.TabIndex = 27;
            this.lblPassTitle.Text = "Visualizar contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(71, 174);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 24;
            this.lblUser.Text = "Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(338, 174);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 23;
            this.lblPass.Text = "Contraseña";
            // 
            // lblSitio
            // 
            this.lblSitio.AutoSize = true;
            this.lblSitio.Location = new System.Drawing.Point(372, 137);
            this.lblSitio.Name = "lblSitio";
            this.lblSitio.Size = new System.Drawing.Size(27, 13);
            this.lblSitio.TabIndex = 25;
            this.lblSitio.Text = "Sitio";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(71, 136);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 26;
            this.lblCat.Text = "Categoría";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(405, 137);
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            this.txtSite.Size = new System.Drawing.Size(167, 20);
            this.txtSite.TabIndex = 20;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(144, 174);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(167, 20);
            this.txtUser.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(405, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 22;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // passwordViewPanel
            // 
            this.passwordViewPanel.Controls.Add(this.txtCategories);
            this.passwordViewPanel.Controls.Add(this.lblPassTitle);
            this.passwordViewPanel.Controls.Add(this.lblUser);
            this.passwordViewPanel.Controls.Add(this.txtPassword);
            this.passwordViewPanel.Controls.Add(this.lblPass);
            this.passwordViewPanel.Controls.Add(this.txtUser);
            this.passwordViewPanel.Controls.Add(this.lblSitio);
            this.passwordViewPanel.Controls.Add(this.txtSite);
            this.passwordViewPanel.Controls.Add(this.lblCat);
            this.passwordViewPanel.Location = new System.Drawing.Point(0, 0);
            this.passwordViewPanel.Name = "passwordViewPanel";
            this.passwordViewPanel.Size = new System.Drawing.Size(642, 343);
            this.passwordViewPanel.TabIndex = 28;
            this.passwordViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.passwordViewPanel_Paint);
            // 
            // txtCategories
            // 
            this.txtCategories.Location = new System.Drawing.Point(144, 134);
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.ReadOnly = true;
            this.txtCategories.Size = new System.Drawing.Size(167, 20);
            this.txtCategories.TabIndex = 28;
            // 
            // PasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordViewPanel);
            this.Name = "PasswordView";
            this.Size = new System.Drawing.Size(645, 346);
            this.Load += new System.EventHandler(this.PasswordView_Load);
            this.passwordViewPanel.ResumeLayout(false);
            this.passwordViewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPassTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblSitio;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel passwordViewPanel;
        private System.Windows.Forms.TextBox txtCategories;
    }
}
