﻿namespace WinForms_DataViewer
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
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataviewerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charactersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_CharacterTable = new System.Windows.Forms.DataGridView();
            this.butt_View = new System.Windows.Forms.Button();
            this.butt_Delete = new System.Windows.Forms.Button();
            this.butt_Exit = new System.Windows.Forms.Button();
            this.butt_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CharacterTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CharacterTable
            // 
            this.dgv_CharacterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CharacterTable.Location = new System.Drawing.Point(12, 12);
            this.dgv_CharacterTable.Name = "dgv_CharacterTable";
            this.dgv_CharacterTable.Size = new System.Drawing.Size(404, 215);
            this.dgv_CharacterTable.TabIndex = 0;
            this.dgv_CharacterTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // butt_View
            // 
            this.butt_View.Location = new System.Drawing.Point(12, 233);
            this.butt_View.Name = "butt_View";
            this.butt_View.Size = new System.Drawing.Size(91, 33);
            this.butt_View.TabIndex = 1;
            this.butt_View.Text = "View";
            this.butt_View.UseVisualStyleBackColor = true;
            // 
            // butt_Delete
            // 
            this.butt_Delete.Location = new System.Drawing.Point(109, 233);
            this.butt_Delete.Name = "butt_Delete";
            this.butt_Delete.Size = new System.Drawing.Size(91, 33);
            this.butt_Delete.TabIndex = 2;
            this.butt_Delete.Text = "Delete";
            this.butt_Delete.UseVisualStyleBackColor = true;
            // 
            // butt_Exit
            // 
            this.butt_Exit.Location = new System.Drawing.Point(325, 233);
            this.butt_Exit.Name = "butt_Exit";
            this.butt_Exit.Size = new System.Drawing.Size(91, 33);
            this.butt_Exit.TabIndex = 3;
            this.butt_Exit.Text = "Exit";
            this.butt_Exit.UseVisualStyleBackColor = true;
            // 
            // butt_Help
            // 
            this.butt_Help.Location = new System.Drawing.Point(228, 233);
            this.butt_Help.Name = "butt_Help";
            this.butt_Help.Size = new System.Drawing.Size(91, 33);
            this.butt_Help.TabIndex = 4;
            this.butt_Help.Text = "Help";
            this.butt_Help.UseVisualStyleBackColor = true;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 275);
            this.Controls.Add(this.butt_Help);
            this.Controls.Add(this.butt_Exit);
            this.Controls.Add(this.butt_Delete);
            this.Controls.Add(this.butt_View);
            this.Controls.Add(this.dgv_CharacterTable);
            this.Name = "ListForm";
            this.Text = "List";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CharacterTable)).EndInit();
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
    }
}

