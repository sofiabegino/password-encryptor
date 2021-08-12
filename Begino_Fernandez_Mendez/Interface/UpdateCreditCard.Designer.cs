
namespace Interface
{
    partial class UpdateCreditCard
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
            this.updateCCPanel = new System.Windows.Forms.Panel();
            this.lblSuccesful = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblSitio = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateCCPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateCCPanel
            // 
            this.updateCCPanel.Controls.Add(this.lblSuccesful);
            this.updateCCPanel.Controls.Add(this.btnVolver);
            this.updateCCPanel.Controls.Add(this.btnAccept);
            this.updateCCPanel.Controls.Add(this.label4);
            this.updateCCPanel.Controls.Add(this.textBoxNotes);
            this.updateCCPanel.Controls.Add(this.label2);
            this.updateCCPanel.Controls.Add(this.label3);
            this.updateCCPanel.Controls.Add(this.textBoxExpirationDate);
            this.updateCCPanel.Controls.Add(this.textBoxCodigo);
            this.updateCCPanel.Controls.Add(this.lblCat);
            this.updateCCPanel.Controls.Add(this.lblSitio);
            this.updateCCPanel.Controls.Add(this.lblUser);
            this.updateCCPanel.Controls.Add(this.lblPass);
            this.updateCCPanel.Controls.Add(this.txtNumber);
            this.updateCCPanel.Controls.Add(this.txtType);
            this.updateCCPanel.Controls.Add(this.txtName);
            this.updateCCPanel.Controls.Add(this.comboBoxCategory);
            this.updateCCPanel.Controls.Add(this.label1);
            this.updateCCPanel.Location = new System.Drawing.Point(3, 3);
            this.updateCCPanel.Name = "updateCCPanel";
            this.updateCCPanel.Size = new System.Drawing.Size(669, 441);
            this.updateCCPanel.TabIndex = 0;
            this.updateCCPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.updateCCPanel_Paint);
            // 
            // lblSuccesful
            // 
            this.lblSuccesful.AutoSize = true;
            this.lblSuccesful.ForeColor = System.Drawing.Color.Red;
            this.lblSuccesful.Location = new System.Drawing.Point(212, 383);
            this.lblSuccesful.Name = "lblSuccesful";
            this.lblSuccesful.Size = new System.Drawing.Size(0, 13);
            this.lblSuccesful.TabIndex = 48;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnVolver.Location = new System.Drawing.Point(25, 23);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAccept.Location = new System.Drawing.Point(264, 272);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 46;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Notas";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(172, 198);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(167, 58);
            this.textBoxNotes.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vencimiento";
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.Location = new System.Drawing.Point(412, 144);
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.Size = new System.Drawing.Size(167, 20);
            this.textBoxExpirationDate.TabIndex = 41;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(412, 101);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(167, 20);
            this.textBoxCodigo.TabIndex = 40;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(104, 60);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 39;
            this.lblCat.Text = "Categoría";
            // 
            // lblSitio
            // 
            this.lblSitio.AutoSize = true;
            this.lblSitio.Location = new System.Drawing.Point(104, 110);
            this.lblSitio.Name = "lblSitio";
            this.lblSitio.Size = new System.Drawing.Size(44, 13);
            this.lblSitio.TabIndex = 38;
            this.lblSitio.Text = "Nombre";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(104, 153);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(28, 13);
            this.lblUser.TabIndex = 37;
            this.lblUser.Text = "Tipo";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(345, 65);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(44, 13);
            this.lblPass.TabIndex = 36;
            this.lblPass.Text = "Número";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(412, 57);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(167, 20);
            this.txtNumber.TabIndex = 35;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(172, 146);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(167, 20);
            this.txtType.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 33;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(172, 57);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategory.TabIndex = 32;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(209, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Actualizar tarjeta de credito";
            // 
            // UpdateCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateCCPanel);
            this.Name = "UpdateCreditCard";
            this.Size = new System.Drawing.Size(672, 447);
            this.updateCCPanel.ResumeLayout(false);
            this.updateCCPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateCCPanel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExpirationDate;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblSitio;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblSuccesful;
    }
}
