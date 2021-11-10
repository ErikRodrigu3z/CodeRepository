namespace CodeRepository.AppForms
{
    partial class Main
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(12, 32);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(167, 23);
            this.cmbCategories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(156, 6);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(23, 23);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "+";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategories);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCategories;
        private Label label1;
        private Button btnCategory;
    }
}