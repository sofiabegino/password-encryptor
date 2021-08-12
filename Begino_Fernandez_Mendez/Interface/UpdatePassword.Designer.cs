
namespace Interface
{
    partial class UpdatePassword
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
            this.updatePassPanel = new System.Windows.Forms.Panel();
            this.lblPassGenerated = new System.Windows.Forms.Label();
            this.txtGeneratedPass = new System.Windows.Forms.TextBox();
            this.lblSuccesful = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.lblPassTitle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblSitio = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecials = new System.Windows.Forms.CheckBox();
            this.checkBoxMay = new System.Windows.Forms.CheckBox();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.updatePassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePassPanel
            // 
            this.updatePassPanel.Controls.Add(this.lblPassGenerated);
            this.updatePassPanel.Controls.Add(this.txtGeneratedPass);
            this.updatePassPanel.Controls.Add(this.lblSuccesful);
            this.updatePassPanel.Controls.Add(this.btnVolver);
            this.updatePassPanel.Controls.Add(this.textBoxNotes);
            this.updatePassPanel.Controls.Add(this.lblPassTitle);
            this.updatePassPanel.Controls.Add(this.lblSize);
            this.updatePassPanel.Controls.Add(this.btnAccept);
            this.updatePassPanel.Controls.Add(this.lblCat);
            this.updatePassPanel.Controls.Add(this.lblSitio);
            this.updatePassPanel.Controls.Add(this.lblUser);
            this.updatePassPanel.Controls.Add(this.lblPass);
            this.updatePassPanel.Controls.Add(this.lblNotes);
            this.updatePassPanel.Controls.Add(this.btnGenerate);
            this.updatePassPanel.Controls.Add(this.checkBoxMin);
            this.updatePassPanel.Controls.Add(this.checkBoxDigits);
            this.updatePassPanel.Controls.Add(this.checkBoxSpecials);
            this.updatePassPanel.Controls.Add(this.checkBoxMay);
            this.updatePassPanel.Controls.Add(this.numericLength);
            this.updatePassPanel.Controls.Add(this.txtPassword);
            this.updatePassPanel.Controls.Add(this.txtUser);
            this.updatePassPanel.Controls.Add(this.txtSite);
            this.updatePassPanel.Controls.Add(this.comboBoxCategories);
            this.updatePassPanel.Location = new System.Drawing.Point(3, 0);
            this.updatePassPanel.Name = "updatePassPanel";
            this.updatePassPanel.Size = new System.Drawing.Size(666, 489);
            this.updatePassPanel.TabIndex = 0;
            this.updatePassPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePassPanel_Paint);
            // 
            // lblPassGenerated
            // 
            this.lblPassGenerated.AutoSize = true;
            this.lblPassGenerated.Location = new System.Drawing.Point(459, 238);
            this.lblPassGenerated.Name = "lblPassGenerated";
            this.lblPassGenerated.Size = new System.Drawing.Size(109, 13);
            this.lblPassGenerated.TabIndex = 53;
            this.lblPassGenerated.Text = "Contraseña generada";
            // 
            // txtGeneratedPass
            // 
            this.txtGeneratedPass.Location = new System.Drawing.Point(434, 257);
            this.txtGeneratedPass.Name = "txtGeneratedPass";
            this.txtGeneratedPass.Size = new System.Drawing.Size(167, 20);
            this.txtGeneratedPass.TabIndex = 52;
            // 
            // lblSuccesful
            // 
            this.lblSuccesful.AutoSize = true;
            this.lblSuccesful.ForeColor = System.Drawing.Color.Red;
            this.lblSuccesful.Location = new System.Drawing.Point(282, 409);
            this.lblSuccesful.Name = "lblSuccesful";
            this.lblSuccesful.Size = new System.Drawing.Size(0, 13);
            this.lblSuccesful.TabIndex = 49;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnVolver.Location = new System.Drawing.Point(25, 23);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 48;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(167, 146);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(167, 61);
            this.textBoxNotes.TabIndex = 38;
            // 
            // lblPassTitle
            // 
            this.lblPassTitle.AutoSize = true;
            this.lblPassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassTitle.Location = new System.Drawing.Point(270, 12);
            this.lblPassTitle.Name = "lblPassTitle";
            this.lblPassTitle.Size = new System.Drawing.Size(157, 16);
            this.lblPassTitle.TabIndex = 37;
            this.lblPassTitle.Text = "Actualizar contraseña";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(499, 131);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 36;
            this.lblSize.Text = "Largo";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAccept.Location = new System.Drawing.Point(237, 257);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 35;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(99, 49);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 34;
            this.lblCat.Text = "Categoría";
            // 
            // lblSitio
            // 
            this.lblSitio.AutoSize = true;
            this.lblSitio.Location = new System.Drawing.Point(99, 99);
            this.lblSitio.Name = "lblSitio";
            this.lblSitio.Size = new System.Drawing.Size(27, 13);
            this.lblSitio.TabIndex = 33;
            this.lblSitio.Text = "Sitio";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(387, 54);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 32;
            this.lblUser.Text = "Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(387, 97);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 31;
            this.lblPass.Text = "Contraseña";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(99, 149);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 30;
            this.lblNotes.Text = "Notas:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGenerate.Location = new System.Drawing.Point(547, 196);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Location = new System.Drawing.Point(369, 153);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(133, 17);
            this.checkBoxMin.TabIndex = 28;
            this.checkBoxMin.Text = "Minúsculas (a, b, c, ...)";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Location = new System.Drawing.Point(369, 179);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(114, 17);
            this.checkBoxDigits.TabIndex = 27;
            this.checkBoxDigits.Text = "Dígitos (0, 1, 2, ...)";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecials
            // 
            this.checkBoxSpecials.AutoSize = true;
            this.checkBoxSpecials.Location = new System.Drawing.Point(369, 202);
            this.checkBoxSpecials.Name = "checkBoxSpecials";
            this.checkBoxSpecials.Size = new System.Drawing.Size(130, 17);
            this.checkBoxSpecials.TabIndex = 26;
            this.checkBoxSpecials.Text = "Especiales (!, $, %, ...)";
            this.checkBoxSpecials.UseVisualStyleBackColor = true;
            // 
            // checkBoxMay
            // 
            this.checkBoxMay.AutoSize = true;
            this.checkBoxMay.Location = new System.Drawing.Point(369, 128);
            this.checkBoxMay.Name = "checkBoxMay";
            this.checkBoxMay.Size = new System.Drawing.Size(136, 17);
            this.checkBoxMay.TabIndex = 25;
            this.checkBoxMay.Text = "Mayúsculas (A, B, C ...)";
            this.checkBoxMay.UseVisualStyleBackColor = true;
            // 
            // numericLength
            // 
            this.numericLength.Location = new System.Drawing.Point(539, 127);
            this.numericLength.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLength.Name = "numericLength";
            this.numericLength.Size = new System.Drawing.Size(83, 20);
            this.numericLength.TabIndex = 24;
            this.numericLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(455, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 23;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(455, 47);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(167, 20);
            this.txtUser.TabIndex = 22;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(167, 92);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(167, 20);
            this.txtSite.TabIndex = 21;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(167, 46);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategories.TabIndex = 20;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updatePassPanel);
            this.Name = "UpdatePassword";
            this.Size = new System.Drawing.Size(672, 489);
            this.updatePassPanel.ResumeLayout(false);
            this.updatePassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updatePassPanel;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label lblPassTitle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblSitio;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxSpecials;
        private System.Windows.Forms.CheckBox checkBoxMay;
        private System.Windows.Forms.NumericUpDown numericLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblSuccesful;
        private System.Windows.Forms.Label lblPassGenerated;
        private System.Windows.Forms.TextBox txtGeneratedPass;
    }
}
