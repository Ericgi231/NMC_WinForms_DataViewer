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
            this.components = new System.ComponentModel.Container();
            this.dgv_CharacterTable = new System.Windows.Forms.DataGridView();
            this.butt_View = new System.Windows.Forms.Button();
            this.butt_Delete = new System.Windows.Forms.Button();
            this.butt_Exit = new System.Windows.Forms.Button();
            this.butt_Help = new System.Windows.Forms.Button();
            this.butt_Save = new System.Windows.Forms.Button();
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataviewerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charactersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_Sort = new System.Windows.Forms.Label();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.tb_SearchValue = new System.Windows.Forms.TextBox();
            this.cb_SearchColumn = new System.Windows.Forms.ComboBox();
            this.cb_SortColumn = new System.Windows.Forms.ComboBox();
            this.cb_Order = new System.Windows.Forms.ComboBox();
            this.pan_Filter = new System.Windows.Forms.Panel();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CharacterTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource1)).BeginInit();
            this.pan_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CharacterTable
            // 
            this.dgv_CharacterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CharacterTable.Location = new System.Drawing.Point(12, 12);
            this.dgv_CharacterTable.Name = "dgv_CharacterTable";
            this.dgv_CharacterTable.Size = new System.Drawing.Size(661, 396);
            this.dgv_CharacterTable.TabIndex = 0;
            // 
            // butt_View
            // 
            this.butt_View.Location = new System.Drawing.Point(679, 12);
            this.butt_View.Name = "butt_View";
            this.butt_View.Size = new System.Drawing.Size(92, 33);
            this.butt_View.TabIndex = 1;
            this.butt_View.Text = "View";
            this.butt_View.UseVisualStyleBackColor = true;
            this.butt_View.Click += new System.EventHandler(this.butt_View_Click);
            // 
            // butt_Delete
            // 
            this.butt_Delete.Location = new System.Drawing.Point(679, 51);
            this.butt_Delete.Name = "butt_Delete";
            this.butt_Delete.Size = new System.Drawing.Size(92, 33);
            this.butt_Delete.TabIndex = 2;
            this.butt_Delete.Text = "Delete";
            this.butt_Delete.UseVisualStyleBackColor = true;
            this.butt_Delete.Click += new System.EventHandler(this.butt_Delete_Click);
            // 
            // butt_Exit
            // 
            this.butt_Exit.Location = new System.Drawing.Point(730, 375);
            this.butt_Exit.Name = "butt_Exit";
            this.butt_Exit.Size = new System.Drawing.Size(41, 33);
            this.butt_Exit.TabIndex = 3;
            this.butt_Exit.Text = "Exit";
            this.butt_Exit.UseVisualStyleBackColor = true;
            this.butt_Exit.Click += new System.EventHandler(this.butt_Exit_Click);
            // 
            // butt_Help
            // 
            this.butt_Help.Location = new System.Drawing.Point(679, 375);
            this.butt_Help.Name = "butt_Help";
            this.butt_Help.Size = new System.Drawing.Size(45, 33);
            this.butt_Help.TabIndex = 4;
            this.butt_Help.Text = "Help";
            this.butt_Help.UseVisualStyleBackColor = true;
            this.butt_Help.Click += new System.EventHandler(this.butt_Help_Click);
            // 
            // butt_Save
            // 
            this.butt_Save.Location = new System.Drawing.Point(679, 340);
            this.butt_Save.Name = "butt_Save";
            this.butt_Save.Size = new System.Drawing.Size(92, 29);
            this.butt_Save.TabIndex = 5;
            this.butt_Save.Text = "Save";
            this.butt_Save.UseVisualStyleBackColor = true;
            this.butt_Save.Click += new System.EventHandler(this.butt_Save_Click);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(676, 101);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 6;
            this.lbl_Search.Text = "Search";
            // 
            // lbl_Sort
            // 
            this.lbl_Sort.AutoSize = true;
            this.lbl_Sort.Location = new System.Drawing.Point(679, 255);
            this.lbl_Sort.Name = "lbl_Sort";
            this.lbl_Sort.Size = new System.Drawing.Size(26, 13);
            this.lbl_Sort.TabIndex = 7;
            this.lbl_Sort.Text = "Sort";
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Location = new System.Drawing.Point(679, 167);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(29, 13);
            this.lbl_Filter.TabIndex = 8;
            this.lbl_Filter.Text = "Filter";
            // 
            // tb_SearchValue
            // 
            this.tb_SearchValue.Location = new System.Drawing.Point(679, 144);
            this.tb_SearchValue.Name = "tb_SearchValue";
            this.tb_SearchValue.Size = new System.Drawing.Size(92, 20);
            this.tb_SearchValue.TabIndex = 9;
            this.tb_SearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Search_KeyPress);
            // 
            // cb_SearchColumn
            // 
            this.cb_SearchColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SearchColumn.FormattingEnabled = true;
            this.cb_SearchColumn.Location = new System.Drawing.Point(679, 117);
            this.cb_SearchColumn.Name = "cb_SearchColumn";
            this.cb_SearchColumn.Size = new System.Drawing.Size(92, 21);
            this.cb_SearchColumn.TabIndex = 10;
            // 
            // cb_SortColumn
            // 
            this.cb_SortColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortColumn.FormattingEnabled = true;
            this.cb_SortColumn.Location = new System.Drawing.Point(679, 271);
            this.cb_SortColumn.Name = "cb_SortColumn";
            this.cb_SortColumn.Size = new System.Drawing.Size(92, 21);
            this.cb_SortColumn.TabIndex = 11;
            this.cb_SortColumn.TextChanged += new System.EventHandler(this.cb_SortColumn_TextChanged);
            // 
            // cb_Order
            // 
            this.cb_Order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Order.FormattingEnabled = true;
            this.cb_Order.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cb_Order.Location = new System.Drawing.Point(679, 298);
            this.cb_Order.Name = "cb_Order";
            this.cb_Order.Size = new System.Drawing.Size(92, 21);
            this.cb_Order.TabIndex = 14;
            this.cb_Order.TextChanged += new System.EventHandler(this.cb_Order_TextChanged);
            // 
            // pan_Filter
            // 
            this.pan_Filter.Controls.Add(this.rb_Female);
            this.pan_Filter.Controls.Add(this.rb_Male);
            this.pan_Filter.Controls.Add(this.rb_All);
            this.pan_Filter.Location = new System.Drawing.Point(679, 184);
            this.pan_Filter.Name = "pan_Filter";
            this.pan_Filter.Size = new System.Drawing.Size(92, 68);
            this.pan_Filter.TabIndex = 15;
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(3, 3);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(36, 17);
            this.rb_All.TabIndex = 0;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "All";
            this.rb_All.UseVisualStyleBackColor = true;
            this.rb_All.CheckedChanged += new System.EventHandler(this.rb_All_CheckedChanged);
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(3, 26);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(48, 17);
            this.rb_Male.TabIndex = 1;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            this.rb_Male.CheckedChanged += new System.EventHandler(this.rb_Male_CheckedChanged);
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(3, 49);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(59, 17);
            this.rb_Female.TabIndex = 2;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            this.rb_Female.CheckedChanged += new System.EventHandler(this.rb_Female_CheckedChanged);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 420);
            this.Controls.Add(this.pan_Filter);
            this.Controls.Add(this.cb_Order);
            this.Controls.Add(this.cb_SortColumn);
            this.Controls.Add(this.cb_SearchColumn);
            this.Controls.Add(this.tb_SearchValue);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.lbl_Sort);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.butt_Save);
            this.Controls.Add(this.butt_Help);
            this.Controls.Add(this.butt_Exit);
            this.Controls.Add(this.butt_Delete);
            this.Controls.Add(this.butt_View);
            this.Controls.Add(this.dgv_CharacterTable);
            this.Name = "ListForm";
            this.Text = "List";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CharacterTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource1)).EndInit();
            this.pan_Filter.ResumeLayout(false);
            this.pan_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource charactersBindingSource;
        private System.Windows.Forms.BindingSource dataviewerDataSetBindingSource;
        private System.Windows.Forms.BindingSource charactersBindingSource1;
        private System.Windows.Forms.DataGridView dgv_CharacterTable;
        private System.Windows.Forms.Button butt_View;
        private System.Windows.Forms.Button butt_Delete;
        private System.Windows.Forms.Button butt_Exit;
        private System.Windows.Forms.Button butt_Help;
        private System.Windows.Forms.Button butt_Save;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_Sort;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.TextBox tb_SearchValue;
        private System.Windows.Forms.ComboBox cb_SearchColumn;
        private System.Windows.Forms.ComboBox cb_SortColumn;
        private System.Windows.Forms.ComboBox cb_Order;
        private System.Windows.Forms.Panel pan_Filter;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_All;
    }
}

