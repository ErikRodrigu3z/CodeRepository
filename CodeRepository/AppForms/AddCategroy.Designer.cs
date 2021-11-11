namespace CodeRepository.AppForms
{
    partial class AddCategroy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValAddCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.Location = new System.Drawing.Point(8, 35);
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(225, 23);
            this.txtAddCategory.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(73, 86);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 47);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Guardar";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar categoria";
            // 
            // lblValAddCategory
            // 
            this.lblValAddCategory.AutoSize = true;
            this.lblValAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValAddCategory.ForeColor = System.Drawing.Color.Red;
            this.lblValAddCategory.Location = new System.Drawing.Point(10, 61);
            this.lblValAddCategory.Name = "lblValAddCategory";
            this.lblValAddCategory.Size = new System.Drawing.Size(223, 15);
            this.lblValAddCategory.TabIndex = 3;
            this.lblValAddCategory.Text = "El nombre de la categoria  es requerido";
            // 
            // AddCategroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 145);
            this.Controls.Add(this.lblValAddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtAddCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCategroy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategroy";
            this.Load += new System.EventHandler(this.AddCategroy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAddCategory;
        private Button btnAddCategory;
        private Label label1;
        private Label lblValAddCategory;
    }
}