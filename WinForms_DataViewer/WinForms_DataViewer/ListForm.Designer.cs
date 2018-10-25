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
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_viewerDataSet = new WinForms_DataViewer.data_viewerDataSet();
            this.charactersTableAdapter = new WinForms_DataViewer.data_viewerDataSetTableAdapters.charactersTableAdapter();
            this.dataviewerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.charactersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_viewerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // charactersBindingSource
            // 
            this.charactersBindingSource.DataMember = "characters";
            this.charactersBindingSource.DataSource = this.data_viewerDataSet;
            // 
            // data_viewerDataSet
            // 
            this.data_viewerDataSet.DataSetName = "data_viewerDataSet";
            this.data_viewerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charactersTableAdapter
            // 
            this.charactersTableAdapter.ClearBeforeFill = true;
            // 
            // dataviewerDataSetBindingSource
            // 
            this.dataviewerDataSetBindingSource.DataSource = this.data_viewerDataSet;
            this.dataviewerDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.charactersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // charactersBindingSource1
            // 
            this.charactersBindingSource1.DataMember = "characters";
            this.charactersBindingSource1.DataSource = this.dataviewerDataSetBindingSource;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListForm";
            this.Text = "List";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_viewerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private data_viewerDataSet data_viewerDataSet;
        private System.Windows.Forms.BindingSource charactersBindingSource;
        private data_viewerDataSetTableAdapters.charactersTableAdapter charactersTableAdapter;
        private System.Windows.Forms.BindingSource dataviewerDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource charactersBindingSource1;
    }
}

