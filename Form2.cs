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
    public partial class Form2 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'karyawanDataSet.Jenis_Kelamin' table. You can move, or remove it, as needed.
            this.jenis_KelaminTableAdapter.Fill(this.karyawanDataSet.Jenis_Kelamin);
            // TODO: This line of code loads data into the 'karyawanDataSet.Umur' table. You can move, or remove it, as needed.
            this.umurTableAdapter.Fill(this.karyawanDataSet.Umur);
            // TODO: This line of code loads data into the 'karyawanDataSet.Nama' table. You can move, or remove it, as needed.
            this.namaTableAdapter.Fill(this.karyawanDataSet.Nama);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;

            textBox2.Text = "";
            textBox3.Text = "";

            int ctr, len;
            string codeval;
            dt = karyawanDataSet.Tables["Jenis_Kelamin"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["kelamin"].ToString();
            codeval = code.Substring(1, 3);
            


            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = karyawanDataSet.Tables["jenis_kelamin"];
            dr = dt.NewRow();
            dr[0] = textBox2.Text;
            dr[1] = textBox3.Text;

            dt.Rows.Add(dr);
            jenis_KelaminTableAdapter.Update(karyawanDataSet);
            textBox2.Text = System.Convert.ToString(dr[0]);
            textBox3.Enabled = false;

            this.jenis_KelaminTableAdapter.Fill(this.karyawanDataSet.Jenis_Kelamin);
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
