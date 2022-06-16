using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeCRUD
{
    public partial class Form4 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'karyawanDataSet.Umur' table. You can move, or remove it, as needed.
            this.umurTableAdapter.Fill(this.karyawanDataSet.Umur);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 main = new Form3();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;

            textBox1.Text = "";
            textBox2.Text = "";

            int ctr, len;
            string codeval;
            dt = karyawanDataSet.Tables["umur"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["id_umur"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);


            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
