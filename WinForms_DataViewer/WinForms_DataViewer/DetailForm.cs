using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_DataViewer.Models;

namespace WinForms_DataViewer
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(Character character)
        {
            InitializeComponent();
            this.Text = character.name;
            string path = $"Resources/{character.img_path}";
            pb_Portrait.ImageLocation = path;
            tb_Description.AppendText(character.description);
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
