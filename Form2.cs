using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUD
{
    public partial class Form2 : Form
    {
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
    }
}
