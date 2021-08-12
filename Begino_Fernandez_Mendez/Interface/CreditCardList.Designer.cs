
namespace Interface
{
    partial class CreditCardList
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
            this.btnAddCreditCard = new System.Windows.Forms.Button();
            this.btnUpdateCreditC = new System.Windows.Forms.Button();
            this.btnDeleteCreditCard = new System.Windows.Forms.Button();
            this.creditCardPanel = new System.Windows.Forms.Panel();
            this.listCreditCards = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVolver = new System.Windows.Forms.Button();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Categoria";
            columnHeader1.Width = 78;
            // 
            // btnAddCreditCard
            // 
            this.btnAddCreditCard.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddCreditCard.Location = new System.Drawing.Point(466, 283);
            this.btnAddCreditCard.Name = "btnAddCreditCard";
            this.btnAddCreditCard.Size = new System.Drawing.Size(128, 23);
            this.btnAddCreditCard.TabIndex = 1;
            this.btnAddCreditCard.Text = "Agregar nueva";
            this.btnAddCreditCard.UseVisualStyleBackColor = false;
            this.btnAddCreditCard.Click += new System.EventHandler(this.btnAddCreditCard_Click);
            // 
            // btnUpdateCreditC
            // 
            this.btnUpdateCreditC.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUpdateCreditC.Location = new System.Drawing.Point(198, 283);
            this.btnUpdateCreditC.Name = "btnUpdateCreditC";
            this.btnUpdateCreditC.Size = new System.Drawing.Size(128, 24);
            this.btnUpdateCreditC.TabIndex = 2;
            this.btnUpdateCreditC.Text = "Actualizar tarjeta";
            this.btnUpdateCreditC.UseVisualStyleBackColor = false;
            this.btnUpdateCreditC.Click += new System.EventHandler(this.btnUpdateCreditC_Click);
            // 
            // btnDeleteCreditCard
            // 
            this.btnDeleteCreditCard.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteCreditCard.Location = new System.Drawing.Point(332, 283);
            this.btnDeleteCreditCard.Name = "btnDeleteCreditCard";
            this.btnDeleteCreditCard.Size = new System.Drawing.Size(128, 24);
            this.btnDeleteCreditCard.TabIndex = 3;
            this.btnDeleteCreditCard.Text = "Borrar tarjeta";
            this.btnDeleteCreditCard.UseVisualStyleBackColor = false;
            this.btnDeleteCreditCard.Click += new System.EventHandler(this.btnDeleteCreditCard_Click);
            // 
            // creditCardPanel
            // 
            this.creditCardPanel.Controls.Add(this.btnVolver);
            this.creditCardPanel.Controls.Add(this.listCreditCards);
            this.creditCardPanel.Controls.Add(this.btnDeleteCreditCard);
            this.creditCardPanel.Controls.Add(this.btnUpdateCreditC);
            this.creditCardPanel.Controls.Add(this.btnAddCreditCard);
            this.creditCardPanel.Location = new System.Drawing.Point(0, 0);
            this.creditCardPanel.Name = "creditCardPanel";
            this.creditCardPanel.Size = new System.Drawing.Size(655, 437);
            this.creditCardPanel.TabIndex = 10;
            this.creditCardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.creditCardPanel_Paint);
            // 
            // listCreditCards
            // 
            this.listCreditCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listCreditCards.HideSelection = false;
            this.listCreditCards.Location = new System.Drawing.Point(147, 62);
            this.listCreditCards.Name = "listCreditCards";
            this.listCreditCards.Size = new System.Drawing.Size(447, 188);
            this.listCreditCards.TabIndex = 12;
            this.listCreditCards.UseCompatibleStateImageBehavior = false;
            this.listCreditCards.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarjeta";
            this.columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vencimiento";
            this.columnHeader5.Width = 137;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(25, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.creditCardPanel);
            this.Name = "CreditCardList";
            this.Size = new System.Drawing.Size(658, 437);
            this.creditCardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddCreditCard;
        private System.Windows.Forms.Button btnUpdateCreditC;
        private System.Windows.Forms.Button btnDeleteCreditCard;
        private System.Windows.Forms.Panel creditCardPanel;
        private System.Windows.Forms.ListView listCreditCards;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnVolver;
    }
}
