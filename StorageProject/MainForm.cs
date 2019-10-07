using StorageProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewStorages.DataSource = Program.db.Storages.Local.ToBindingList();
        }            

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void dataGridViewStorages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStorages.SelectedRows.Count > 0)
            {
                int index = dataGridViewStorages.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewStorages[0, index].Value.ToString(), out id);

                if (!converted)
                    return;

                Storage st = Program.db.Storages.Find(id);
                dataGridViewProducts.DataSource = st?.Products.ToList();
            }
        }

        private void AddStorageItem_btn_Click(object sender, EventArgs e)
        {
            //int index= dataGridViewProducts.SelectedRows[0].Index;

        }

        private void DeleteStorageItem_btn_Click(object sender, EventArgs e)
        {

        }

        private void AddStorage_btn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStorage_btn_Click(object sender, EventArgs e)
        {
            //TODO: confirm // с учетом допуска сотрудника
            int[] ids = new int[dataGridViewStorages.SelectedRows.Count];
            for (int i = 0; i < ids.Length; i++)
            {
                int ind = dataGridViewStorages.SelectedRows[i].Index;
                bool converted = Int32.TryParse(dataGridViewStorages[0, ind].Value.ToString(), out  ids[i]);
                if (!converted)
                    break;
            }
            for (int i = 0; i < ids.Length; i++)
            {
                Storage st = Program.db.Storages.Find(ids[i]);
                Program.db.Storages.Remove(st);
            }
            Program.db.SaveChanges();
        }
    }
}
