
namespace Interface
{
    partial class DataBreaches
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
            this.DataBreachesPanel = new System.Windows.Forms.Panel();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnHistorialDB = new System.Windows.Forms.Button();
            this.btnVolverDB = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblDataBreaches = new System.Windows.Forms.Label();
            this.richTextBoxDataBreaches = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DataBreachesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataBreachesPanel
            // 
            this.DataBreachesPanel.Controls.Add(this.lblSelectFile);
            this.DataBreachesPanel.Controls.Add(this.textBoxFile);
            this.DataBreachesPanel.Controls.Add(this.btnSelectFile);
            this.DataBreachesPanel.Controls.Add(this.btnHistorialDB);
            this.DataBreachesPanel.Controls.Add(this.btnVolverDB);
            this.DataBreachesPanel.Controls.Add(this.btnVerificar);
            this.DataBreachesPanel.Controls.Add(this.lblDataBreaches);
            this.DataBreachesPanel.Controls.Add(this.richTextBoxDataBreaches);
            this.DataBreachesPanel.Location = new System.Drawing.Point(3, 3);
            this.DataBreachesPanel.Name = "DataBreachesPanel";
            this.DataBreachesPanel.Size = new System.Drawing.Size(684, 487);
            this.DataBreachesPanel.TabIndex = 4;
            this.DataBreachesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DataBreachesPanel_Paint);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Location = new System.Drawing.Point(207, 326);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(113, 13);
            this.lblSelectFile.TabIndex = 12;
            this.lblSelectFile.Text = "Ubicación del archivo:";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(198, 353);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(281, 20);
            this.textBoxFile.TabIndex = 11;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(25, 350);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(154, 23);
            this.btnSelectFile.TabIndex = 10;
            this.btnSelectFile.Text = "Seleccionar un archivo";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnHistorialDB
            // 
            this.btnHistorialDB.Location = new System.Drawing.Point(25, 262);
            this.btnHistorialDB.Name = "btnHistorialDB";
            this.btnHistorialDB.Size = new System.Drawing.Size(154, 23);
            this.btnHistorialDB.TabIndex = 9;
            this.btnHistorialDB.Text = "Historial de DataBreaches";
            this.btnHistorialDB.UseVisualStyleBackColor = true;
            this.btnHistorialDB.Click += new System.EventHandler(this.btnHistorialDB_Click);
            // 
            // btnVolverDB
            // 
            this.btnVolverDB.Location = new System.Drawing.Point(16, 18);
            this.btnVolverDB.Name = "btnVolverDB";
            this.btnVolverDB.Size = new System.Drawing.Size(125, 25);
            this.btnVolverDB.TabIndex = 8;
            this.btnVolverDB.Text = "Volver";
            this.btnVolverDB.UseVisualStyleBackColor = true;
            this.btnVolverDB.Click += new System.EventHandler(this.btnVolverDB_Click_1);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(532, 238);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(99, 25);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click_1);
            // 
            // lblDataBreaches
            // 
            this.lblDataBreaches.AutoSize = true;
            this.lblDataBreaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBreaches.Location = new System.Drawing.Point(283, 27);
            this.lblDataBreaches.Name = "lblDataBreaches";
            this.lblDataBreaches.Size = new System.Drawing.Size(107, 16);
            this.lblDataBreaches.TabIndex = 6;
            this.lblDataBreaches.Text = "DataBreaches";
            this.lblDataBreaches.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBoxDataBreaches
            // 
            this.richTextBoxDataBreaches.Location = new System.Drawing.Point(207, 74);
            this.richTextBoxDataBreaches.Name = "richTextBoxDataBreaches";
            this.richTextBoxDataBreaches.Size = new System.Drawing.Size(424, 149);
            this.richTextBoxDataBreaches.TabIndex = 5;
            this.richTextBoxDataBreaches.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // DataBreaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataBreachesPanel);
            this.Name = "DataBreaches";
            this.Size = new System.Drawing.Size(687, 493);
            this.DataBreachesPanel.ResumeLayout(false);
            this.DataBreachesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DataBreachesPanel;
        private System.Windows.Forms.Label lblDataBreaches;
        private System.Windows.Forms.RichTextBox richTextBoxDataBreaches;
        private System.Windows.Forms.Button btnVolverDB;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnHistorialDB;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
