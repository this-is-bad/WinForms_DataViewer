namespace WinForms_DataViewer
{
    partial class DetailForm
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
            this.picBox_Photo = new System.Windows.Forms.PictureBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_LastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox_Photo
            // 
            this.picBox_Photo.Location = new System.Drawing.Point(2, 2);
            this.picBox_Photo.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_Photo.Name = "picBox_Photo";
            this.picBox_Photo.Size = new System.Drawing.Size(103, 89);
            this.picBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Photo.TabIndex = 3;
            this.picBox_Photo.TabStop = false;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(2, 0);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(112, 26);
            this.lbl_FullName.TabIndex = 4;
            this.lbl_FullName.Text = "Full Name";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(2, 39);
            this.lbl_Age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_Age.Size = new System.Drawing.Size(26, 13);
            this.lbl_Age.TabIndex = 5;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(2, 52);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_Gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_Gender.TabIndex = 6;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(2, 146);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Description.MaximumSize = new System.Drawing.Size(255, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(76, 16);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.Click += new System.EventHandler(this.lbl_Description_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(3, 0);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_Id.Size = new System.Drawing.Size(16, 13);
            this.lbl_Id.TabIndex = 9;
            this.lbl_Id.Text = "Id";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picBox_Photo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 111);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Id, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Gender, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Age, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_FirstName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_LastName, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(110, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(79, 105);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(3, 13);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 10;
            this.lbl_FirstName.Text = "First Name";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Close.AutoSize = true;
            this.btn_Close.Location = new System.Drawing.Point(82, 187);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(56, 23);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_FullName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Close, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Description, 0, 2);
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.44086F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.2258F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 236);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(3, 26);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 11;
            this.lbl_LastName.Text = "Last Name";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(295, 218);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox_Photo;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
    }
}