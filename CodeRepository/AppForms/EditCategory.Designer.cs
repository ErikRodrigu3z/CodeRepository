namespace CodeRepository.AppForms
{
    partial class EditCategory
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
            this.lblValAddCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditCategory = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblValAddCategory
            // 
            this.lblValAddCategory.AutoSize = true;
            this.lblValAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValAddCategory.ForeColor = System.Drawing.Color.Red;
            this.lblValAddCategory.Location = new System.Drawing.Point(14, 64);
            this.lblValAddCategory.Name = "lblValAddCategory";
            this.lblValAddCategory.Size = new System.Drawing.Size(223, 15);
            this.lblValAddCategory.TabIndex = 7;
            this.lblValAddCategory.Text = "El nombre de la categoria  es requerido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Editar categoria";
            // 
            // txtEditCategory
            // 
            this.txtEditCategory.Location = new System.Drawing.Point(12, 38);
            this.txtEditCategory.Name = "txtEditCategory";
            this.txtEditCategory.Size = new System.Drawing.Size(225, 23);
            this.txtEditCategory.TabIndex = 4;
            this.txtEditCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditCategory_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(81, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 47);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 155);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblValAddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCategory";
            this.Load += new System.EventHandler(this.EditCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValAddCategory;
        private Label label1;
        private TextBox txtEditCategory;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}