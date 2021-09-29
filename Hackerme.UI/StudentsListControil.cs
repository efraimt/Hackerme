using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackerme.UI
{
    public partial class StudentsListControil : UserControl
    {
        public StudentsListControil()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsListControil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  MyDB.StudendsTable.List;
        }
    }
}
