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
            this.gvCategory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCategory
            // 
            this.gvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCategory.Location = new System.Drawing.Point(67, 44);
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.RowTemplate.Height = 25;
            this.gvCategory.Size = new System.Drawing.Size(355, 217);
            this.gvCategory.TabIndex = 0;
            // 
            // AddCategroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 338);
            this.Controls.Add(this.gvCategory);
            this.Name = "AddCategroy";
            this.Text = "AddCategroy";
            this.Load += new System.EventHandler(this.AddCategroy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gvCategory;
    }
}