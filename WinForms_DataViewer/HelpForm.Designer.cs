namespace WinForms_DataViewer
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.picBox_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.Location = new System.Drawing.Point(153, 287);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(56, 23);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(13, 13);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(234, 20);
            this.lbl_Header.TabIndex = 10;
            this.lbl_Header.Text = "How to Use This Application";
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.Location = new System.Drawing.Point(17, 52);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(342, 153);
            this.lbl_Instructions.TabIndex = 11;
            this.lbl_Instructions.Text = resources.GetString("lbl_Instructions.Text");
            // 
            // picBox_Photo
            // 
            this.picBox_Photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Photo.Location = new System.Drawing.Point(274, 227);
            this.picBox_Photo.Name = "picBox_Photo";
            this.picBox_Photo.Size = new System.Drawing.Size(107, 96);
            this.picBox_Photo.TabIndex = 12;
            this.picBox_Photo.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.picBox_Photo);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_Close);
            this.Name = "HelpForm";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.PictureBox picBox_Photo;
    }
}