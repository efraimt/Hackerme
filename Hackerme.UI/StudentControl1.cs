using Hackerme.Infrastucture.Entities;
using MyDB;
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
    public partial class StudentControl1 : UserControl
    {

        public Student Student { get; set; }
        public StudentControl1()
        {
            InitializeComponent();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Student.FirstName = txtFirst.Text;
            Student.DOB = DateOnly.FromDateTime(dtpDOB.Value);
            Student.CityId = cmbCity.SelectedIndex;

            //if (inAddMode)
            MyDB.StudendsTable.Add(Student);


        }

        private void StudentControl1_Load(object sender, EventArgs e)
        {
            Student = new Student();
            cmbCity.DataSource = CityList.List;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = StudendsTable.Filter(ByFirst);
            //Student = MyDB.StudendsTable.Search(txtSearchName.Text);

            //txtFirst.Text = Student.FirstName;
            //DateOnly.FromDateTime(dtpDOB.Value) = Student.DOB;
            //cmbCity.SelectedIndex = Student.CityId;
        }

        public bool ByLast(Student student)
        {
            return student.LastName.Contains(txtTerm.Text);
        }

        public bool ByFirst(Student student)
        {
            return student.FirstName.Contains(txtTerm.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            LogDelegate logDelegate= new LogDelegate(new ConsoleLogger().Log);
            logDelegate += new FileLogger().Log;

            StudendsTable.Remove(StudendsTable.List[0],logDelegate );
        }

        private void btnSearchByLast_Click(object sender, EventArgs e)
        {
            var list = StudendsTable.Filter(ByLast);
        }
    }
}
