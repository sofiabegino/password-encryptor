
namespace Interface
{
    partial class SharePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.Sitio = new System.Windows.Forms.Label();
            this.SharePassPanel = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAcept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.SharePassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compartir contraseña";
            // 
            // Sitio
            // 
            this.Sitio.AutoSize = true;
            this.Sitio.Location = new System.Drawing.Point(157, 132);
            this.Sitio.Name = "Sitio";
            this.Sitio.Size = new System.Drawing.Size(0, 13);
            this.Sitio.TabIndex = 6;
            // 
            // SharePassPanel
            // 
            this.SharePassPanel.Controls.Add(this.btnVolver);
            this.SharePassPanel.Controls.Add(this.btnAcept);
            this.SharePassPanel.Controls.Add(this.label3);
            this.SharePassPanel.Controls.Add(this.label2);
            this.SharePassPanel.Controls.Add(this.label4);
            this.SharePassPanel.Controls.Add(this.comboBoxUsers);
            this.SharePassPanel.Controls.Add(this.txtUser);
            this.SharePassPanel.Controls.Add(this.txtSite);
            this.SharePassPanel.Controls.Add(this.label1);
            this.SharePassPanel.Location = new System.Drawing.Point(0, 0);
            this.SharePassPanel.Name = "SharePassPanel";
            this.SharePassPanel.Size = new System.Drawing.Size(603, 339);
            this.SharePassPanel.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 20);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 28);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(246, 231);
            this.btnAcept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(79, 27);
            this.btnAcept.TabIndex = 7;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sitio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Compartir con:";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(225, 86);
            this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(178, 21);
            this.comboBoxUsers.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(225, 176);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(178, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(225, 129);
            this.txtSite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(178, 20);
            this.txtSite.TabIndex = 1;
            // 
            // SharePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sitio);
            this.Controls.Add(this.SharePassPanel);
            this.Name = "SharePassword";
            this.Size = new System.Drawing.Size(603, 339);
            this.SharePassPanel.ResumeLayout(false);
            this.SharePassPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Sitio;
        private System.Windows.Forms.Panel SharePassPanel;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
