
namespace Interface
{
    partial class CreateCreditCard
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
            this.createCreditCardPanel = new System.Windows.Forms.Panel();
            this.lblSucces = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblSitio = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.createCreditCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCreditCardPanel
            // 
            this.createCreditCardPanel.Controls.Add(this.btnVolver);
            this.createCreditCardPanel.Controls.Add(this.lblSucces);
            this.createCreditCardPanel.Controls.Add(this.btnAccept);
            this.createCreditCardPanel.Controls.Add(this.label4);
            this.createCreditCardPanel.Controls.Add(this.txtNotes);
            this.createCreditCardPanel.Controls.Add(this.label2);
            this.createCreditCardPanel.Controls.Add(this.label3);
            this.createCreditCardPanel.Controls.Add(this.txtExpirationDate);
            this.createCreditCardPanel.Controls.Add(this.txtCodigo);
            this.createCreditCardPanel.Controls.Add(this.lblCat);
            this.createCreditCardPanel.Controls.Add(this.lblSitio);
            this.createCreditCardPanel.Controls.Add(this.lblUser);
            this.createCreditCardPanel.Controls.Add(this.lblPass);
            this.createCreditCardPanel.Controls.Add(this.txtNumber);
            this.createCreditCardPanel.Controls.Add(this.txtType);
            this.createCreditCardPanel.Controls.Add(this.txtName);
            this.createCreditCardPanel.Controls.Add(this.comboBoxCategory);
            this.createCreditCardPanel.Controls.Add(this.label1);
            this.createCreditCardPanel.Location = new System.Drawing.Point(2, 0);
            this.createCreditCardPanel.Name = "createCreditCardPanel";
            this.createCreditCardPanel.Size = new System.Drawing.Size(866, 441);
            this.createCreditCardPanel.TabIndex = 0;
            this.createCreditCardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createCrediCardPanel_Paint);
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.ForeColor = System.Drawing.Color.Red;
            this.lblSucces.Location = new System.Drawing.Point(374, 375);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(0, 13);
            this.lblSucces.TabIndex = 49;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAccept.Location = new System.Drawing.Point(353, 267);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 30;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Notas";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(178, 182);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(167, 58);
            this.txtNotes.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vencimiento";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Location = new System.Drawing.Point(430, 133);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(167, 20);
            this.txtExpirationDate.TabIndex = 25;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(430, 90);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(167, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(110, 50);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 23;
            this.lblCat.Text = "Categoría";
            // 
            // lblSitio
            // 
            this.lblSitio.AutoSize = true;
            this.lblSitio.Location = new System.Drawing.Point(110, 100);
            this.lblSitio.Name = "lblSitio";
            this.lblSitio.Size = new System.Drawing.Size(44, 13);
            this.lblSitio.TabIndex = 22;
            this.lblSitio.Text = "Nombre";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(110, 143);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(28, 13);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Tipo";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(363, 54);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(44, 13);
            this.lblPass.TabIndex = 20;
            this.lblPass.Text = "Número";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(430, 50);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(167, 20);
            this.txtNumber.TabIndex = 19;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(178, 136);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(167, 20);
            this.txtType.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 17;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(178, 47);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategory.TabIndex = 16;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(365, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create credit card";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 16);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 50;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // CreateCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createCreditCardPanel);
            this.Name = "CreateCreditCard";
            this.Size = new System.Drawing.Size(871, 441);
            this.createCreditCardPanel.ResumeLayout(false);
            this.createCreditCardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel createCreditCardPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblSitio;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblSucces;
        private System.Windows.Forms.Button btnVolver;
    }
}
