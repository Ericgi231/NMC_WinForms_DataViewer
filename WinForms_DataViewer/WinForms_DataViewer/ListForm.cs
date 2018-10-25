using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_DataViewer.Data;
using WinForms_DataViewer.DAL;
using WinForms_DataViewer.Models;

namespace WinForms_DataViewer
{
    public partial class ListForm : Form
    {
        private List<Character> characters;

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            try
            {
                ReadMongoAndBindToDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex}","Error");
            }
        }

        private void ReadMongoAndBindToDataGrid()
        {
            //
            // read data file
            //
            IDataService dataService = new MongoDataService();
            characters = dataService.ReadAll();

            //
            // bind list to DataGridView control
            //
            var bindingList = new BindingList<Character>(characters);
            var source = new BindingSource(bindingList, null);
            dgv_CharacterTable.DataSource = source;

        }

        private void butt_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                IDataService ds = new MongoDataService();
                ds.WriteAll(characters);
            }
            catch (Exception)
            {

                throw;
            }
            this.Close();
            Application.Exit();
        }

        private void butt_Help_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        private void butt_View_Click(object sender, EventArgs e)
        {
            if (dgv_CharacterTable.SelectedRows.Count == 1)
            {
                Character character = new Character();
                character = (Character)dgv_CharacterTable.CurrentRow.DataBoundItem;

                DetailForm detailForm = new DetailForm(character);
                detailForm.Show();
            }
        }

        private void butt_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_CharacterTable.SelectedRows)
            {
                dgv_CharacterTable.Rows.RemoveAt(row.Index);
            }
        }
    }
}
