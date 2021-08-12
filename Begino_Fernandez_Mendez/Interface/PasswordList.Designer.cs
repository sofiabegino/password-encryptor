
namespace Interface
{
    partial class PasswordList
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.btnDeletePass = new System.Windows.Forms.Button();
            this.btnAddPassword = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.btnStopShare = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listPasswords = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeeChart = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Categoria";
            columnHeader1.Width = 97;
            // 
            // btnDeletePass
            // 
            this.btnDeletePass.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDeletePass.Location = new System.Drawing.Point(182, 292);
            this.btnDeletePass.Name = "btnDeletePass";
            this.btnDeletePass.Size = new System.Drawing.Size(129, 23);
            this.btnDeletePass.TabIndex = 7;
            this.btnDeletePass.Text = "Borrar contraseña";
            this.btnDeletePass.UseVisualStyleBackColor = false;
            this.btnDeletePass.Click += new System.EventHandler(this.btnDeletePass_Click);
            // 
            // btnAddPassword
            // 
            this.btnAddPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddPassword.Location = new System.Drawing.Point(452, 292);
            this.btnAddPassword.Name = "btnAddPassword";
            this.btnAddPassword.Size = new System.Drawing.Size(124, 23);
            this.btnAddPassword.TabIndex = 5;
            this.btnAddPassword.Text = "Agregar nueva";
            this.btnAddPassword.UseVisualStyleBackColor = false;
            this.btnAddPassword.Click += new System.EventHandler(this.btnAddPassword_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.button4);
            this.passwordPanel.Controls.Add(this.btnStopShare);
            this.passwordPanel.Controls.Add(this.button3);
            this.passwordPanel.Controls.Add(this.btnUpdatePass);
            this.passwordPanel.Controls.Add(this.btnVolver);
            this.passwordPanel.Controls.Add(this.button2);
            this.passwordPanel.Controls.Add(this.listPasswords);
            this.passwordPanel.Controls.Add(this.button1);
            this.passwordPanel.Controls.Add(this.btnSeeChart);
            this.passwordPanel.Controls.Add(this.btnDeletePass);
            this.passwordPanel.Controls.Add(this.btnAddPassword);
            this.passwordPanel.Location = new System.Drawing.Point(0, 0);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(641, 417);
            this.passwordPanel.TabIndex = 9;
            this.passwordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.passwordPanel_Paint);
            // 
            // btnStopShare
            // 
            this.btnStopShare.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStopShare.Location = new System.Drawing.Point(25, 234);
            this.btnStopShare.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopShare.Name = "btnStopShare";
            this.btnStopShare.Size = new System.Drawing.Size(131, 23);
            this.btnStopShare.TabIndex = 16;
            this.btnStopShare.Text = "Dejar de compartir";
            this.btnStopShare.UseVisualStyleBackColor = false;
            this.btnStopShare.Click += new System.EventHandler(this.btnStopShare_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 12);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnUpdatePass.Location = new System.Drawing.Point(318, 293);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(128, 22);
            this.btnUpdatePass.TabIndex = 14;
            this.btnUpdatePass.Text = "Actualizar contraseña";
            this.btnUpdatePass.UseVisualStyleBackColor = false;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnVolver.Location = new System.Drawing.Point(25, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.Location = new System.Drawing.Point(25, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Visualizar contraseña";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listPasswords
            // 
            this.listPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listPasswords.HideSelection = false;
            this.listPasswords.Location = new System.Drawing.Point(161, 60);
            this.listPasswords.Name = "listPasswords";
            this.listPasswords.Size = new System.Drawing.Size(444, 197);
            this.listPasswords.TabIndex = 11;
            this.listPasswords.UseCompatibleStateImageBehavior = false;
            this.listPasswords.View = System.Windows.Forms.View.Details;
            this.listPasswords.SelectedIndexChanged += new System.EventHandler(this.listPasswords_SelectedIndexChanged_1);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sitio";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Usuario";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ultima Modificacion";
            this.columnHeader4.Width = 204;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Compartida";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(25, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Compartir contraseña";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeeChart
            // 
            this.btnSeeChart.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSeeChart.Location = new System.Drawing.Point(25, 106);
            this.btnSeeChart.Name = "btnSeeChart";
            this.btnSeeChart.Size = new System.Drawing.Size(131, 23);
            this.btnSeeChart.TabIndex = 9;
            this.btnSeeChart.Text = "Ver graficas";
            this.btnSeeChart.UseVisualStyleBackColor = false;
            this.btnSeeChart.Click += new System.EventHandler(this.btnSeeChart_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BurlyWood;
            this.button4.Location = new System.Drawing.Point(25, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "Ver Usuarios Compartidos";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordPanel);
            this.Name = "PasswordList";
            this.Size = new System.Drawing.Size(641, 417);
            this.Load += new System.EventHandler(this.Password_Load);
            this.passwordPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePass;
        private System.Windows.Forms.Button btnAddPassword;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Button btnSeeChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listPasswords;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Button btnStopShare;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button4;
    }
}
