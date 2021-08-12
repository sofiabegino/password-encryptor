
namespace Interface
{
    partial class DataBreachesHistory
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
            this.dataBreachesHistoryPanel = new System.Windows.Forms.Panel();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listDBHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataBreachesHistoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBreachesHistoryPanel
            // 
            this.dataBreachesHistoryPanel.Controls.Add(this.btnViewData);
            this.dataBreachesHistoryPanel.Controls.Add(this.btnVolver);
            this.dataBreachesHistoryPanel.Controls.Add(this.listDBHistory);
            this.dataBreachesHistoryPanel.Location = new System.Drawing.Point(3, 3);
            this.dataBreachesHistoryPanel.Name = "dataBreachesHistoryPanel";
            this.dataBreachesHistoryPanel.Size = new System.Drawing.Size(657, 460);
            this.dataBreachesHistoryPanel.TabIndex = 0;
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(276, 340);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(124, 23);
            this.btnViewData.TabIndex = 2;
            this.btnViewData.Text = "Ver Historico";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(19, 14);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 28);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // listDBHistory
            // 
            this.listDBHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listDBHistory.HideSelection = false;
            this.listDBHistory.Location = new System.Drawing.Point(143, 83);
            this.listDBHistory.Name = "listDBHistory";
            this.listDBHistory.Size = new System.Drawing.Size(415, 225);
            this.listDBHistory.TabIndex = 0;
            this.listDBHistory.UseCompatibleStateImageBehavior = false;
            this.listDBHistory.View = System.Windows.Forms.View.Details;
            this.listDBHistory.SelectedIndexChanged += new System.EventHandler(this.listDBHistory_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            // 
            // DataBreachesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataBreachesHistoryPanel);
            this.Name = "DataBreachesHistory";
            this.Size = new System.Drawing.Size(663, 466);
            this.dataBreachesHistoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataBreachesHistoryPanel;
        private System.Windows.Forms.ListView listDBHistory;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
