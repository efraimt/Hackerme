using Hackerme.Infrastucture.Entities;
using Hackerme.UI;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentControl1 studentControl1= new StudentControl1();

            panel1.Controls.Clear();
            panel1.Controls.Add(studentControl1);
            studentControl1.Dock = DockStyle.Fill;


        }

        private void bleToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var control1=new  StudentControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(control1);
            control1.Dock = DockStyle.Fill;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control1 = new StudentsListControil();
            
            panel1.Controls.Clear();
            panel1.Controls.Add(control1);
            control1.Dock = DockStyle.Fill;
        }


        List<Student> students = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(new Student() { Id = 1, FirstName = "Aharon" });
            students.Add(new Student() { Id = 2, FirstName = "Yael" });
            
            //dataGridView1.DataSource = students;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control1 = new StudentsListControil();
            
            panel1.Controls.Clear();
            panel1.Controls.Add(control1);
            control1.Dock = DockStyle.Fill;
        }
    }
}
