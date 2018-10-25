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
            this.butt_back = new System.Windows.Forms.Button();
            this.pb_Portrait = new System.Windows.Forms.PictureBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // butt_back
            // 
            this.butt_back.Location = new System.Drawing.Point(265, 197);
            this.butt_back.Name = "butt_back";
            this.butt_back.Size = new System.Drawing.Size(92, 40);
            this.butt_back.TabIndex = 0;
            this.butt_back.Text = "Back";
            this.butt_back.UseVisualStyleBackColor = true;
            this.butt_back.Click += new System.EventHandler(this.butt_back_Click);
            // 
            // pb_Portrait
            // 
            this.pb_Portrait.Location = new System.Drawing.Point(12, 12);
            this.pb_Portrait.Name = "pb_Portrait";
            this.pb_Portrait.Size = new System.Drawing.Size(163, 225);
            this.pb_Portrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Portrait.TabIndex = 1;
            this.pb_Portrait.TabStop = false;
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(182, 13);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(175, 178);
            this.tb_Description.TabIndex = 2;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 244);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.pb_Portrait);
            this.Controls.Add(this.butt_back);
            this.Name = "DetailForm";
            this.Text = "Detail";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Portrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_back;
        private System.Windows.Forms.PictureBox pb_Portrait;
        private System.Windows.Forms.TextBox tb_Description;
    }
}