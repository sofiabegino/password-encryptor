
namespace Interface
{
    partial class CreatePassword
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
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMay = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecials = new System.Windows.Forms.CheckBox();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSitio = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPassTitle = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.createPassPanel = new System.Windows.Forms.Panel();
            this.lblPassGenerated = new System.Windows.Forms.Label();
            this.txtGeneratedPass = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            this.createPassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(154, 58);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategories.TabIndex = 0;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(412, 59);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(167, 20);
            this.txtSite.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(154, 96);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(167, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(412, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // numericLength
            // 
            this.numericLength.Location = new System.Drawing.Point(493, 152);
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
            this.numericLength.TabIndex = 4;
            this.numericLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkBoxMay
            // 
            this.checkBoxMay.AutoSize = true;
            this.checkBoxMay.Location = new System.Drawing.Point(348, 136);
            this.checkBoxMay.Name = "checkBoxMay";
            this.checkBoxMay.Size = new System.Drawing.Size(136, 17);
            this.checkBoxMay.TabIndex = 5;
            this.checkBoxMay.Text = "Mayúsculas (A, B, C ...)";
            this.checkBoxMay.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecials
            // 
            this.checkBoxSpecials.AutoSize = true;
            this.checkBoxSpecials.Location = new System.Drawing.Point(348, 205);
            this.checkBoxSpecials.Name = "checkBoxSpecials";
            this.checkBoxSpecials.Size = new System.Drawing.Size(130, 17);
            this.checkBoxSpecials.TabIndex = 6;
            this.checkBoxSpecials.Text = "Especiales (!, $, %, ...)";
            this.checkBoxSpecials.UseVisualStyleBackColor = true;
            this.checkBoxSpecials.CheckedChanged += new System.EventHandler(this.checkBoxSpecials_CheckedChanged);
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Location = new System.Drawing.Point(348, 182);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(114, 17);
            this.checkBoxDigits.TabIndex = 7;
            this.checkBoxDigits.Text = "Dígitos (0, 1, 2, ...)";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            this.checkBoxDigits.CheckedChanged += new System.EventHandler(this.checkBoxDigits_CheckedChanged);
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Location = new System.Drawing.Point(348, 159);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(133, 17);
            this.checkBoxMin.TabIndex = 8;
            this.checkBoxMin.Text = "Minúsculas (a, b, c, ...)";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            this.checkBoxMin.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGenerate.Location = new System.Drawing.Point(493, 233);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(94, 162);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Notas:";
            this.lblNotes.Click += new System.EventHandler(this.lblNotes_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(345, 96);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(78, 96);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Usuario";
            // 
            // lblSitio
            // 
            this.lblSitio.AutoSize = true;
            this.lblSitio.Location = new System.Drawing.Point(379, 59);
            this.lblSitio.Name = "lblSitio";
            this.lblSitio.Size = new System.Drawing.Size(27, 13);
            this.lblSitio.TabIndex = 14;
            this.lblSitio.Text = "Sitio";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(78, 58);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 15;
            this.lblCat.Text = "Categoría";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAccept.Location = new System.Drawing.Point(218, 300);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(490, 136);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 17;
            this.lblSize.Text = "Largo";
            // 
            // lblPassTitle
            // 
            this.lblPassTitle.AutoSize = true;
            this.lblPassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassTitle.Location = new System.Drawing.Point(267, 10);
            this.lblPassTitle.Name = "lblPassTitle";
            this.lblPassTitle.Size = new System.Drawing.Size(127, 16);
            this.lblPassTitle.TabIndex = 18;
            this.lblPassTitle.Text = "Crear contraseña";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(154, 159);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(171, 66);
            this.textBoxNotes.TabIndex = 19;
            this.textBoxNotes.TextChanged += new System.EventHandler(this.textBoxNotes_TextChanged);
            // 
            // createPassPanel
            // 
            this.createPassPanel.Controls.Add(this.btnVolver);
            this.createPassPanel.Controls.Add(this.lblPassGenerated);
            this.createPassPanel.Controls.Add(this.txtGeneratedPass);
            this.createPassPanel.Controls.Add(this.btnAccept);
            this.createPassPanel.Controls.Add(this.textBoxNotes);
            this.createPassPanel.Controls.Add(this.lblNotes);
            this.createPassPanel.Controls.Add(this.lblSize);
            this.createPassPanel.Controls.Add(this.lblPassTitle);
            this.createPassPanel.Controls.Add(this.btnGenerate);
            this.createPassPanel.Controls.Add(this.lblUser);
            this.createPassPanel.Controls.Add(this.lblPass);
            this.createPassPanel.Controls.Add(this.lblSitio);
            this.createPassPanel.Controls.Add(this.numericLength);
            this.createPassPanel.Controls.Add(this.checkBoxSpecials);
            this.createPassPanel.Controls.Add(this.checkBoxDigits);
            this.createPassPanel.Controls.Add(this.checkBoxMin);
            this.createPassPanel.Controls.Add(this.lblCat);
            this.createPassPanel.Controls.Add(this.comboBoxCategories);
            this.createPassPanel.Controls.Add(this.txtSite);
            this.createPassPanel.Controls.Add(this.checkBoxMay);
            this.createPassPanel.Controls.Add(this.txtUser);
            this.createPassPanel.Controls.Add(this.txtPassword);
            this.createPassPanel.Location = new System.Drawing.Point(0, 0);
            this.createPassPanel.Name = "createPassPanel";
            this.createPassPanel.Size = new System.Drawing.Size(851, 474);
            this.createPassPanel.TabIndex = 50;
            this.createPassPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createPassPanel_Paint);
            // 
            // lblPassGenerated
            // 
            this.lblPassGenerated.AutoSize = true;
            this.lblPassGenerated.Location = new System.Drawing.Point(437, 274);
            this.lblPassGenerated.Name = "lblPassGenerated";
            this.lblPassGenerated.Size = new System.Drawing.Size(109, 13);
            this.lblPassGenerated.TabIndex = 51;
            this.lblPassGenerated.Text = "Contraseña generada";
            // 
            // txtGeneratedPass
            // 
            this.txtGeneratedPass.Location = new System.Drawing.Point(412, 293);
            this.txtGeneratedPass.Name = "txtGeneratedPass";
            this.txtGeneratedPass.Size = new System.Drawing.Size(167, 20);
            this.txtGeneratedPass.TabIndex = 50;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // CreatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createPassPanel);
            this.Name = "CreatePassword";
            this.Size = new System.Drawing.Size(854, 474);
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            this.createPassPanel.ResumeLayout(false);
            this.createPassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.NumericUpDown numericLength;
        private System.Windows.Forms.CheckBox checkBoxMay;
        private System.Windows.Forms.CheckBox checkBoxSpecials;
        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSitio;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPassTitle;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Panel createPassPanel;
        private System.Windows.Forms.Label lblPassGenerated;
        private System.Windows.Forms.TextBox txtGeneratedPass;
        private System.Windows.Forms.Button btnVolver;
    }
}
