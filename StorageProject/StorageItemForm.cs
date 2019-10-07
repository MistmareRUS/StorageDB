using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class StorageItemForm : Form
    {
        private int StorageId;
        private int ProductId;
        public StorageItemForm(int storageId)
        {
            InitializeComponent();
            StorageId = storageId;
        }
    }
}
