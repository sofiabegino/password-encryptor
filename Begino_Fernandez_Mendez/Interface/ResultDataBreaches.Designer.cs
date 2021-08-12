
namespace Interface
{
    partial class ResultDataBreaches
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
            this.resultDataBreachesPanel = new System.Windows.Forms.Panel();
            this.listBoxDBPass = new System.Windows.Forms.ListBox();
            this.listBoxDBCreditC = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarPass = new System.Windows.Forms.Button();
            this.btnModificarCC = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.resultDataBreachesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultDataBreachesPanel
            // 
            this.resultDataBreachesPanel.Controls.Add(this.btnVolver);
            this.resultDataBreachesPanel.Controls.Add(this.btnModificarCC);
            this.resultDataBreachesPanel.Controls.Add(this.btnModificarPass);
            this.resultDataBreachesPanel.Controls.Add(this.listBoxDBPass);
            this.resultDataBreachesPanel.Controls.Add(this.listBoxDBCreditC);
            this.resultDataBreachesPanel.Controls.Add(this.label2);
            this.resultDataBreachesPanel.Controls.Add(this.label1);
            this.resultDataBreachesPanel.Location = new System.Drawing.Point(2, 0);
            this.resultDataBreachesPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resultDataBreachesPanel.Name = "resultDataBreachesPanel";
            this.resultDataBreachesPanel.Size = new System.Drawing.Size(1456, 829);
            this.resultDataBreachesPanel.TabIndex = 0;
            this.resultDataBreachesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resultDataBreachesPanel_Paint);
            // 
            // listBoxDBPass
            // 
            this.listBoxDBPass.FormattingEnabled = true;
            this.listBoxDBPass.ItemHeight = 25;
            this.listBoxDBPass.Location = new System.Drawing.Point(276, 401);
            this.listBoxDBPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxDBPass.Name = "listBoxDBPass";
            this.listBoxDBPass.Size = new System.Drawing.Size(930, 204);
            this.listBoxDBPass.TabIndex = 51;
            // 
            // listBoxDBCreditC
            // 
            this.listBoxDBCreditC.FormattingEnabled = true;
            this.listBoxDBCreditC.ItemHeight = 25;
            this.listBoxDBCreditC.Location = new System.Drawing.Point(276, 113);
            this.listBoxDBCreditC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxDBCreditC.Name = "listBoxDBCreditC";
            this.listBoxDBCreditC.Size = new System.Drawing.Size(930, 204);
            this.listBoxDBCreditC.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 360);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Las siguientes contraseñas han sido expuestas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Las siguientes tarjetas han sido expuestas:";
            // 
            // btnModificarPass
            // 
            this.btnModificarPass.Location = new System.Drawing.Point(1056, 624);
            this.btnModificarPass.Name = "btnModificarPass";
            this.btnModificarPass.Size = new System.Drawing.Size(150, 42);
            this.btnModificarPass.TabIndex = 52;
            this.btnModificarPass.Text = "Modificar";
            this.btnModificarPass.UseVisualStyleBackColor = true;
            this.btnModificarPass.Click += new System.EventHandler(this.btnModificarPass_Click);
            // 
            // btnModificarCC
            // 
            this.btnModificarCC.Location = new System.Drawing.Point(1046, 327);
            this.btnModificarCC.Name = "btnModificarCC";
            this.btnModificarCC.Size = new System.Drawing.Size(160, 45);
            this.btnModificarCC.TabIndex = 53;
            this.btnModificarCC.Text = "Modificar";
            this.btnModificarCC.UseVisualStyleBackColor = true;
            this.btnModificarCC.Click += new System.EventHandler(this.btnModificarCC_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(21, 30);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(162, 47);
            this.btnVolver.TabIndex = 54;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // ResultDataBreaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultDataBreachesPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ResultDataBreaches";
            this.Size = new System.Drawing.Size(1464, 839);
            this.resultDataBreachesPanel.ResumeLayout(false);
            this.resultDataBreachesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel resultDataBreachesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDBCreditC;
        private System.Windows.Forms.ListBox listBoxDBPass;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificarCC;
        private System.Windows.Forms.Button btnModificarPass;
    }
}
