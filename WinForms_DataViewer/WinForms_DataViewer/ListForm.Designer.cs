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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CharacterTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CharacterTable
            // 
            this.dgv_CharacterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CharacterTable.Location = new System.Drawing.Point(12, 12);
            this.dgv_CharacterTable.Name = "dgv_CharacterTable";
            this.dgv_CharacterTable.Size = new System.Drawing.Size(666, 402);
            this.dgv_CharacterTable.TabIndex = 0;
            // 
            // butt_View
            // 
            this.butt_View.Location = new System.Drawing.Point(12, 420);
            this.butt_View.Name = "butt_View";
            this.butt_View.Size = new System.Drawing.Size(91, 33);
            this.butt_View.TabIndex = 1;
            this.butt_View.Text = "View";
            this.butt_View.UseVisualStyleBackColor = true;
            this.butt_View.Click += new System.EventHandler(this.butt_View_Click);
            // 
            // butt_Delete
            // 
            this.butt_Delete.Location = new System.Drawing.Point(109, 420);
            this.butt_Delete.Name = "butt_Delete";
            this.butt_Delete.Size = new System.Drawing.Size(91, 33);
            this.butt_Delete.TabIndex = 2;
            this.butt_Delete.Text = "Delete";
            this.butt_Delete.UseVisualStyleBackColor = true;
            this.butt_Delete.Click += new System.EventHandler(this.butt_Delete_Click);
            // 
            // butt_Exit
            // 
            this.butt_Exit.Location = new System.Drawing.Point(731, 420);
            this.butt_Exit.Name = "butt_Exit";
            this.butt_Exit.Size = new System.Drawing.Size(91, 33);
            this.butt_Exit.TabIndex = 3;
            this.butt_Exit.Text = "Exit";
            this.butt_Exit.UseVisualStyleBackColor = true;
            this.butt_Exit.Click += new System.EventHandler(this.butt_Exit_Click);
            // 
            // butt_Help
            // 
            this.butt_Help.Location = new System.Drawing.Point(634, 420);
            this.butt_Help.Name = "butt_Help";
            this.butt_Help.Size = new System.Drawing.Size(91, 33);
            this.butt_Help.TabIndex = 4;
            this.butt_Help.Text = "Help";
            this.butt_Help.UseVisualStyleBackColor = true;
            this.butt_Help.Click += new System.EventHandler(this.butt_Help_Click);
            // 
            // butt_Save
            // 
            this.butt_Save.Location = new System.Drawing.Point(380, 420);
            this.butt_Save.Name = "butt_Save";
            this.butt_Save.Size = new System.Drawing.Size(91, 33);
            this.butt_Save.TabIndex = 5;
            this.butt_Save.Text = "Save";
            this.butt_Save.UseVisualStyleBackColor = true;
            this.butt_Save.Click += new System.EventHandler(this.butt_Save_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 465);
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
            this.ResumeLayout(false);

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
    }
}

