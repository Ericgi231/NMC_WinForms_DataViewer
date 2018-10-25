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
            this.butt_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butt_Back
            // 
            this.butt_Back.Location = new System.Drawing.Point(293, 215);
            this.butt_Back.Name = "butt_Back";
            this.butt_Back.Size = new System.Drawing.Size(75, 23);
            this.butt_Back.TabIndex = 0;
            this.butt_Back.Text = "Back";
            this.butt_Back.UseVisualStyleBackColor = true;
            this.butt_Back.Click += new System.EventHandler(this.butt_Back_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_Back);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butt_Back;
    }
}