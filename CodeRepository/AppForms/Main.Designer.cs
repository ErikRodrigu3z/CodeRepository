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
            this.gvArticle = new System.Windows.Forms.DataGridView();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnEditArticle = new FontAwesome.Sharp.IconButton();
            this.btnAddArticle = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditCategory = new FontAwesome.Sharp.IconButton();
            this.btnAddCategory = new FontAwesome.Sharp.IconButton();
            this.lblIdCategory = new System.Windows.Forms.Label();
            this.lblIdArticle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(14, 55);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(196, 23);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // gvArticle
            // 
            this.gvArticle.AllowUserToAddRows = false;
            this.gvArticle.AllowUserToDeleteRows = false;
            this.gvArticle.AllowUserToOrderColumns = true;
            this.gvArticle.AllowUserToResizeColumns = false;
            this.gvArticle.AllowUserToResizeRows = false;
            this.gvArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvArticle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gvArticle.Location = new System.Drawing.Point(15, 84);
            this.gvArticle.Name = "gvArticle";
            this.gvArticle.ReadOnly = true;
            this.gvArticle.RowTemplate.Height = 25;
            this.gvArticle.Size = new System.Drawing.Size(195, 553);
            this.gvArticle.TabIndex = 3;
            this.gvArticle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvArticle_CellClick);
            // 
            // txtArticle
            // 
            this.txtArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArticle.Location = new System.Drawing.Point(15, 115);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArticle.Size = new System.Drawing.Size(839, 521);
            this.txtArticle.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(15, 71);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(839, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Articulo";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(629, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(215, 30);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "0001-01-01 00:00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblIdArticle);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEditArticle);
            this.groupBox1.Controls.Add(this.btnAddArticle);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtArticle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(253, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 653);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contenido";
            // 
            // btnClear
            // 
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.btnClear.IconColor = System.Drawing.Color.Gray;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 28;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(108, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(42, 32);
            this.btnClear.TabIndex = 11;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEditArticle
            // 
            this.btnEditArticle.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditArticle.IconColor = System.Drawing.Color.Gray;
            this.btnEditArticle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditArticle.IconSize = 28;
            this.btnEditArticle.Location = new System.Drawing.Point(60, 17);
            this.btnEditArticle.Name = "btnEditArticle";
            this.btnEditArticle.Size = new System.Drawing.Size(42, 32);
            this.btnEditArticle.TabIndex = 10;
            this.btnEditArticle.UseVisualStyleBackColor = true;
            this.btnEditArticle.Click += new System.EventHandler(this.btnEditArticle_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddArticle.IconColor = System.Drawing.Color.Gray;
            this.btnAddArticle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddArticle.IconSize = 28;
            this.btnAddArticle.Location = new System.Drawing.Point(12, 17);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(42, 32);
            this.btnAddArticle.TabIndex = 9;
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnEditCategory);
            this.groupBox2.Controls.Add(this.btnAddCategory);
            this.groupBox2.Controls.Add(this.lblIdCategory);
            this.groupBox2.Controls.Add(this.gvArticle);
            this.groupBox2.Controls.Add(this.cmbCategories);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 653);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditCategory.IconColor = System.Drawing.Color.Gray;
            this.btnEditCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCategory.IconSize = 28;
            this.btnEditCategory.Location = new System.Drawing.Point(168, 17);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(42, 32);
            this.btnEditCategory.TabIndex = 12;
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCategory.IconColor = System.Drawing.Color.Gray;
            this.btnAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategory.IconSize = 28;
            this.btnAddCategory.Location = new System.Drawing.Point(120, 17);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(42, 32);
            this.btnAddCategory.TabIndex = 11;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.AutoSize = true;
            this.lblIdCategory.Location = new System.Drawing.Point(81, 31);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(14, 15);
            this.lblIdCategory.TabIndex = 4;
            this.lblIdCategory.Text = "1";
            // 
            // lblIdArticle
            // 
            this.lblIdArticle.AutoSize = true;
            this.lblIdArticle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdArticle.Location = new System.Drawing.Point(72, 97);
            this.lblIdArticle.Name = "lblIdArticle";
            this.lblIdArticle.Size = new System.Drawing.Size(14, 15);
            this.lblIdArticle.TabIndex = 12;
            this.lblIdArticle.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1134, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "la";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvArticle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private ComboBox cmbCategories;
        private Label label1;
        private DataGridView gvArticle;
        private TextBox txtArticle;
        private TextBox txtTitle;
        private Label label2;
        private Label label3;
        private Label lblDate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblIdCategory;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnEditArticle;
        private FontAwesome.Sharp.IconButton btnAddArticle;        
        private FontAwesome.Sharp.IconButton btnEditCategory;
        private FontAwesome.Sharp.IconButton btnAddCategory;
        private Label lblIdArticle;
    }
}