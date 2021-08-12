
namespace Interface
{
    partial class ViewDataBreach
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
            this.panelViewData = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.listViewCards = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPasswords = new System.Windows.Forms.ListView();
            this.Modificada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sitio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelViewData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewData
            // 
            this.panelViewData.Controls.Add(this.btnVolver);
            this.panelViewData.Controls.Add(this.btnUpdatePass);
            this.panelViewData.Controls.Add(this.listViewCards);
            this.panelViewData.Controls.Add(this.listViewPasswords);
            this.panelViewData.Location = new System.Drawing.Point(4, 5);
            this.panelViewData.Name = "panelViewData";
            this.panelViewData.Size = new System.Drawing.Size(824, 566);
            this.panelViewData.TabIndex = 0;
            this.panelViewData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelViewData_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(33, 41);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 34);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Location = new System.Drawing.Point(440, 210);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(141, 28);
            this.btnUpdatePass.TabIndex = 2;
            this.btnUpdatePass.Text = "Actualizar Contraseña";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // listViewCards
            // 
            this.listViewCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCards.HideSelection = false;
            this.listViewCards.Location = new System.Drawing.Point(137, 259);
            this.listViewCards.Name = "listViewCards";
            this.listViewCards.Size = new System.Drawing.Size(445, 152);
            this.listViewCards.TabIndex = 1;
            this.listViewCards.UseCompatibleStateImageBehavior = false;
            this.listViewCards.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarjeta";
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vencimiento";
            this.columnHeader4.Width = 104;
            // 
            // listViewPasswords
            // 
            this.listViewPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Modificada,
            this.Sitio,
            this.Usuario});
            this.listViewPasswords.HideSelection = false;
            this.listViewPasswords.Location = new System.Drawing.Point(137, 41);
            this.listViewPasswords.Name = "listViewPasswords";
            this.listViewPasswords.Size = new System.Drawing.Size(444, 154);
            this.listViewPasswords.TabIndex = 0;
            this.listViewPasswords.UseCompatibleStateImageBehavior = false;
            this.listViewPasswords.View = System.Windows.Forms.View.Details;
            this.listViewPasswords.SelectedIndexChanged += new System.EventHandler(this.listViewPasswords_SelectedIndexChanged);
            // 
            // Modificada
            // 
            this.Modificada.Text = "Fue Modificada";
            this.Modificada.Width = 107;
            // 
            // Sitio
            // 
            this.Sitio.Text = "Sitio";
            this.Sitio.Width = 128;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            this.Usuario.Width = 85;
            // 
            // ViewDataBreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelViewData);
            this.Name = "ViewDataBreach";
            this.Size = new System.Drawing.Size(848, 574);
            this.Load += new System.EventHandler(this.ViewDataBreach_Load);
            this.panelViewData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelViewData;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.ListView listViewCards;
        private System.Windows.Forms.ListView listViewPasswords;
        private System.Windows.Forms.ColumnHeader Modificada;
        private System.Windows.Forms.ColumnHeader Sitio;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
