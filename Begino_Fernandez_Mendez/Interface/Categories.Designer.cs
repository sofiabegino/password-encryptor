
namespace Interface
{
    partial class Categories
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
            this.categoriesPanel = new System.Windows.Forms.Panel();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.categoriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.Controls.Add(this.button1);
            this.categoriesPanel.Controls.Add(this.txtNewName);
            this.categoriesPanel.Controls.Add(this.lblCategory);
            this.categoriesPanel.Controls.Add(this.txtCategory);
            this.categoriesPanel.Controls.Add(this.label1);
            this.categoriesPanel.Controls.Add(this.listCategories);
            this.categoriesPanel.Controls.Add(this.btnUpdateCategory);
            this.categoriesPanel.Controls.Add(this.btnAddCategory);
            this.categoriesPanel.Controls.Add(this.btnBack);
            this.categoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.Size = new System.Drawing.Size(675, 388);
            this.categoriesPanel.TabIndex = 0;
            this.categoriesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.categoriesPanel_Paint);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(302, 331);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(148, 20);
            this.txtNewName.TabIndex = 10;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(225, 333);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 13);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Nuevo nombre:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(276, 74);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(148, 20);
            this.txtCategory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categoría:";
            // 
            // listCategories
            // 
            this.listCategories.FormattingEnabled = true;
            this.listCategories.Location = new System.Drawing.Point(202, 148);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(396, 160);
            this.listCategories.TabIndex = 4;
            this.listCategories.SelectedIndexChanged += new System.EventHandler(this.listCategories_SelectedIndexChanged);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUpdateCategory.Location = new System.Drawing.Point(470, 328);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(128, 24);
            this.btnUpdateCategory.TabIndex = 6;
            this.btnUpdateCategory.Text = "Actualizar categoría";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCreditC_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddCategory.Location = new System.Drawing.Point(447, 71);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(128, 23);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Agregar nueva";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCreditCard_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBack.Location = new System.Drawing.Point(25, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ver Contraseñas Compartidas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoriesPanel);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(674, 388);
            this.categoriesPanel.ResumeLayout(false);
            this.categoriesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel categoriesPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button button1;
    }
}
