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
            List<Character> characters = dataService.ReadAll();

            //
            // bind list to DataGridView control
            //
            var bindingList = new BindingList<Character>(characters);
            var source = new BindingSource(bindingList, null);
            dgv_CharacterTable.DataSource = source;

            //
            // configure DataGridView control
            //
            this.dgv_CharacterTable.Columns["_id"].Visible = false;
            this.dgv_CharacterTable.Columns["img_path"].Visible = false;
            this.dgv_CharacterTable.Columns["description"].Visible = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
