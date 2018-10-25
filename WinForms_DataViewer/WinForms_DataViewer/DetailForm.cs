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
            //set form label
            this.Text = character.name;

            //set image
            string path = $"Resources/{character.img_path}";
            pb_Portrait.ErrorImage = Properties.Resources.ErrorImage;
            pb_Portrait.ImageLocation = path;

            //set text
            tb_Description.AppendText("Name: " + character.name);
            tb_Description.AppendText("\r\nWeapon: " + character.weapon);
            tb_Description.AppendText("\r\nGender: " + character.gender);
            tb_Description.AppendText("\r\nDescription: " + character.description);
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
