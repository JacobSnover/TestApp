using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            int y;

            x = int.Parse(textBox1.Text);

            y = int.Parse(textBox2.Text);

            int result = x + y;

            label3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Apple");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //List<Employee> mylist = new List<Employee>();

            //// file io to read into the list 

            //foreach(Employee emp in mylist)

            //dataGridView1.Rows.Add(emp.Name, emp.Salary);
            
        }
    }
}
