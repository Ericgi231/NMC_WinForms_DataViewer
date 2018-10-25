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
            this.butt_Back = new System.Windows.Forms.Button();
            this.tb_Help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butt_Back
            // 
            this.butt_Back.Location = new System.Drawing.Point(348, 184);
            this.butt_Back.Name = "butt_Back";
            this.butt_Back.Size = new System.Drawing.Size(76, 55);
            this.butt_Back.TabIndex = 0;
            this.butt_Back.Text = "Back";
            this.butt_Back.UseVisualStyleBackColor = true;
            this.butt_Back.Click += new System.EventHandler(this.butt_Back_Click);
            // 
            // tb_Help
            // 
            this.tb_Help.Location = new System.Drawing.Point(12, 12);
            this.tb_Help.Multiline = true;
            this.tb_Help.Name = "tb_Help";
            this.tb_Help.Size = new System.Drawing.Size(412, 166);
            this.tb_Help.TabIndex = 1;
            this.tb_Help.Text = resources.GetString("tb_Help.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 251);
            this.Controls.Add(this.tb_Help);
            this.Controls.Add(this.butt_Back);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_Back;
        private System.Windows.Forms.TextBox tb_Help;
    }
}