namespace WinForms_DataViewer
{
    partial class ListForm
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
            this.dataGridView_Characters = new System.Windows.Forms.DataGridView();
            this.btn_DetailView = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_SearchMessage = new System.Windows.Forms.Label();
            this.cmb_Filter = new System.Windows.Forms.ComboBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.lbl_FilterMessage = new System.Windows.Forms.Label();
            this.btn_ClearSearch = new System.Windows.Forms.Button();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Characters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Characters
            // 
            this.dataGridView_Characters.AllowUserToAddRows = false;
            this.dataGridView_Characters.AllowUserToDeleteRows = false;
            this.dataGridView_Characters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Characters.Location = new System.Drawing.Point(33, 114);
            this.dataGridView_Characters.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Characters.Name = "dataGridView_Characters";
            this.dataGridView_Characters.RowTemplate.Height = 24;
            this.dataGridView_Characters.Size = new System.Drawing.Size(477, 186);
            this.dataGridView_Characters.TabIndex = 0;
            this.dataGridView_Characters.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Characters_DataBindingComplete);
            // 
            // btn_DetailView
            // 
            this.btn_DetailView.Location = new System.Drawing.Point(237, 319);
            this.btn_DetailView.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DetailView.Name = "btn_DetailView";
            this.btn_DetailView.Size = new System.Drawing.Size(81, 39);
            this.btn_DetailView.TabIndex = 2;
            this.btn_DetailView.Text = "View Detail";
            this.btn_DetailView.UseVisualStyleBackColor = true;
            this.btn_DetailView.Click += new System.EventHandler(this.btn_DetailView_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(101, 7);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(355, 29);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Characters from The Flintstones";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(429, 319);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(33, 319);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(81, 39);
            this.btn_Help.TabIndex = 5;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(33, 54);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 6;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(171, 55);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(100, 22);
            this.txt_Search.TabIndex = 7;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(124, 55);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 8;
            this.lbl_Search.Text = "Search";
            // 
            // lbl_SearchMessage
            // 
            this.lbl_SearchMessage.AutoSize = true;
            this.lbl_SearchMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchMessage.Location = new System.Drawing.Point(201, 85);
            this.lbl_SearchMessage.Name = "lbl_SearchMessage";
            this.lbl_SearchMessage.Size = new System.Drawing.Size(117, 15);
            this.lbl_SearchMessage.TabIndex = 9;
            this.lbl_SearchMessage.Text = "lbl_SearchMessage";
            // 
            // cmb_Filter
            // 
            this.cmb_Filter.FormattingEnabled = true;
            this.cmb_Filter.Items.AddRange(new object[] {
            "",
            "Female",
            "Male"});
            this.cmb_Filter.Location = new System.Drawing.Point(373, 57);
            this.cmb_Filter.Name = "cmb_Filter";
            this.cmb_Filter.Size = new System.Drawing.Size(88, 21);
            this.cmb_Filter.TabIndex = 10;
            this.cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter_SelectedIndexChanged);
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Location = new System.Drawing.Point(338, 57);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(29, 13);
            this.lbl_Filter.TabIndex = 11;
            this.lbl_Filter.Text = "Filter";
            // 
            // lbl_FilterMessage
            // 
            this.lbl_FilterMessage.AutoSize = true;
            this.lbl_FilterMessage.Location = new System.Drawing.Point(373, 85);
            this.lbl_FilterMessage.Name = "lbl_FilterMessage";
            this.lbl_FilterMessage.Size = new System.Drawing.Size(88, 13);
            this.lbl_FilterMessage.TabIndex = 12;
            this.lbl_FilterMessage.Text = "lbl_FilterMessage";
            this.lbl_FilterMessage.Visible = false;
            // 
            // btn_ClearSearch
            // 
            this.btn_ClearSearch.Location = new System.Drawing.Point(278, 55);
            this.btn_ClearSearch.Name = "btn_ClearSearch";
            this.btn_ClearSearch.Size = new System.Drawing.Size(40, 23);
            this.btn_ClearSearch.TabIndex = 13;
            this.btn_ClearSearch.Text = "Clear";
            this.btn_ClearSearch.UseVisualStyleBackColor = true;
            this.btn_ClearSearch.Click += new System.EventHandler(this.btn_ClearSearch_Click);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Location = new System.Drawing.Point(470, 57);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(40, 23);
            this.btn_ClearFilter.TabIndex = 14;
            this.btn_ClearFilter.Text = "Clear";
            this.btn_ClearFilter.UseVisualStyleBackColor = true;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 386);
            this.Controls.Add(this.btn_ClearFilter);
            this.Controls.Add(this.btn_ClearSearch);
            this.Controls.Add(this.lbl_FilterMessage);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.cmb_Filter);
            this.Controls.Add(this.lbl_SearchMessage);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_DetailView);
            this.Controls.Add(this.dataGridView_Characters);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListForm";
            this.Text = "Cartoon Characters";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Characters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Characters;
        private System.Windows.Forms.Button btn_DetailView;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_SearchMessage;
        private System.Windows.Forms.ComboBox cmb_Filter;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.Label lbl_FilterMessage;
        private System.Windows.Forms.Button btn_ClearSearch;
        private System.Windows.Forms.Button btn_ClearFilter;
    }
}

