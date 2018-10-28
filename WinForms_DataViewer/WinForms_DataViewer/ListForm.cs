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
                SetComboBox();
                SetSort();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}","Error");
            }
        }

        private void SetSort()
        {
            List<DataGridViewRow> sorted;
            BindingList<Character> bindingList;
            BindingSource source;
            switch (cb_Order.Text)
            {
                case "Ascending":
                    sorted = (from item in dgv_CharacterTable.Rows.Cast<DataGridViewRow>()
                              where item.Index != dgv_CharacterTable.Rows.Count - 1
                              orderby item.Cells[cb_SortColumn.Text].Value ascending
                              select item).ToList<DataGridViewRow>();
                    characters = sorted.Select(x => x.DataBoundItem).Cast<Character>().ToList();
                    bindingList = new BindingList<Character>(characters);
                    source = new BindingSource(bindingList, null);
                    dgv_CharacterTable.DataSource = source;
                    break;
                case "Descending":
                    sorted = (from item in dgv_CharacterTable.Rows.Cast<DataGridViewRow>()
                              where item.Index != dgv_CharacterTable.Rows.Count-1
                              orderby item.Cells[cb_SortColumn.Text].Value descending
                              select item).ToList<DataGridViewRow>();
                    characters = sorted.Select(x => x.DataBoundItem).Cast<Character>().ToList();
                    bindingList = new BindingList<Character>(characters);
                    source = new BindingSource(bindingList, null);
                    dgv_CharacterTable.DataSource = source;
                    break;
            }
            
        }

        private void SetComboBox()
        {
            foreach (DataGridViewColumn column in dgv_CharacterTable.Columns)
            {
                cb_SearchColumn.Items.Add(column.Name);
                cb_SortColumn.Items.Add(column.Name);
            }
            cb_SearchColumn.SelectedIndex = 0;
            cb_SortColumn.SelectedIndex = 0;

            cb_Order.SelectedIndex = 0;
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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error");
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
                try
                {
                    dgv_CharacterTable.Rows.RemoveAt(row.Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Error");
                }
            }
        }

        private void butt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                IDataService ds = new MongoDataService();
                ds.WriteAll(characters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error");
            }
        }

        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dgv_CharacterTable.ClearSelection();
                int colIndex = 0;
                foreach (DataGridViewColumn column in dgv_CharacterTable.Columns)
                {
                    if (column.Name == cb_SearchColumn.Text)
                    {
                        colIndex = column.Index;
                    }
                }

                foreach (DataGridViewRow row in dgv_CharacterTable.Rows)
                {
                    try
                    {
                        if (row.Cells[colIndex].Value.ToString().ToLower() == tb_SearchValue.Text.ToLower())
                        {
                            row.Selected = true;
                        }
                    }
                    catch (Exception) { }
                }

                if (dgv_CharacterTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Value not found.", "Error");
                }
            }
        }

        private void cb_Order_TextChanged(object sender, EventArgs e)
        {
            SetSort();
        }

        private void cb_SortColumn_TextChanged(object sender, EventArgs e)
        {
            SetSort();
        }

        private void tb_FilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                
            }
        }

        private void rb_All_CheckedChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void SetFilter()
        {
            string selected = pan_Filter.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            dgv_CharacterTable.ClearSelection();
            bool empty = true;
            foreach (DataGridViewRow row in dgv_CharacterTable.Rows)
            {
                if (selected != "All")
                {
                    try
                    {
                        if (row.Cells["Gender"].Value.ToString().ToLower() == selected.ToLower())
                        {
                            row.Visible = true;
                            empty = false;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                    catch (Exception) { }
                }
                else
                {
                    row.Visible = true;
                }
            }
            if (empty)
            {
                MessageBox.Show($"No values found with gender {selected}","Error");
            }
        }
    }
}
