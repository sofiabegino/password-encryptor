
namespace Interface
{
    partial class SystemOptions
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
            this.systemOptionsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPasswordsStrength = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnDataBreaches = new System.Windows.Forms.Button();
            this.btnAddNewPass = new System.Windows.Forms.Button();
            this.btnAddNewCreditC = new System.Windows.Forms.Button();
            this.systemOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemOptionsPanel
            // 
            this.systemOptionsPanel.Controls.Add(this.button1);
            this.systemOptionsPanel.Controls.Add(this.btnPasswordsStrength);
            this.systemOptionsPanel.Controls.Add(this.btnCategories);
            this.systemOptionsPanel.Controls.Add(this.btnDataBreaches);
            this.systemOptionsPanel.Controls.Add(this.btnAddNewPass);
            this.systemOptionsPanel.Controls.Add(this.btnAddNewCreditC);
            this.systemOptionsPanel.Location = new System.Drawing.Point(3, 3);
            this.systemOptionsPanel.Name = "systemOptionsPanel";
            this.systemOptionsPanel.Size = new System.Drawing.Size(669, 447);
            this.systemOptionsPanel.TabIndex = 0;
            this.systemOptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SystemOptionsPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(39, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPasswordsStrength
            // 
            this.btnPasswordsStrength.BackColor = System.Drawing.Color.Bisque;
            this.btnPasswordsStrength.Location = new System.Drawing.Point(236, 301);
            this.btnPasswordsStrength.Name = "btnPasswordsStrength";
            this.btnPasswordsStrength.Size = new System.Drawing.Size(159, 37);
            this.btnPasswordsStrength.TabIndex = 4;
            this.btnPasswordsStrength.Text = "Reporte de Fortaleza";
            this.btnPasswordsStrength.UseVisualStyleBackColor = false;
            this.btnPasswordsStrength.Click += new System.EventHandler(this.BtnPasswordsStrength_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Bisque;
            this.btnCategories.Location = new System.Drawing.Point(236, 178);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(159, 37);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "Mis categorías";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDataBreaches
            // 
            this.btnDataBreaches.BackColor = System.Drawing.Color.Bisque;
            this.btnDataBreaches.Location = new System.Drawing.Point(236, 241);
            this.btnDataBreaches.Name = "btnDataBreaches";
            this.btnDataBreaches.Size = new System.Drawing.Size(159, 37);
            this.btnDataBreaches.TabIndex = 2;
            this.btnDataBreaches.Text = "Data Breaches";
            this.btnDataBreaches.UseVisualStyleBackColor = false;
            this.btnDataBreaches.Click += new System.EventHandler(this.BtnDataBreaches_Click);
            // 
            // btnAddNewPass
            // 
            this.btnAddNewPass.BackColor = System.Drawing.Color.Bisque;
            this.btnAddNewPass.Location = new System.Drawing.Point(236, 43);
            this.btnAddNewPass.Name = "btnAddNewPass";
            this.btnAddNewPass.Size = new System.Drawing.Size(159, 37);
            this.btnAddNewPass.TabIndex = 0;
            this.btnAddNewPass.Text = "Mis contraseñas";
            this.btnAddNewPass.UseVisualStyleBackColor = false;
            this.btnAddNewPass.Click += new System.EventHandler(this.BtnAddNewPass_Click);
            // 
            // btnAddNewCreditC
            // 
            this.btnAddNewCreditC.BackColor = System.Drawing.Color.Bisque;
            this.btnAddNewCreditC.Location = new System.Drawing.Point(236, 111);
            this.btnAddNewCreditC.Name = "btnAddNewCreditC";
            this.btnAddNewCreditC.Size = new System.Drawing.Size(159, 38);
            this.btnAddNewCreditC.TabIndex = 1;
            this.btnAddNewCreditC.Text = "Mis tarjetas";
            this.btnAddNewCreditC.UseVisualStyleBackColor = false;
            this.btnAddNewCreditC.Click += new System.EventHandler(this.BtnAddNewCreditC_Click);
            // 
            // SystemOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.systemOptionsPanel);
            this.Name = "SystemOptions";
            this.Size = new System.Drawing.Size(675, 453);
            this.Load += new System.EventHandler(this.SystemOptions_Load);
            this.systemOptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel systemOptionsPanel;
        private System.Windows.Forms.Button btnAddNewPass;
        private System.Windows.Forms.Button btnAddNewCreditC;
        private System.Windows.Forms.Button btnDataBreaches;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnPasswordsStrength;
        private System.Windows.Forms.Button button1;
    }
}
