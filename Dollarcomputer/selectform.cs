using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollarcomputer
{
    public partial class selectform : Form
    {
        public selectform()
        {
            InitializeComponent();
        }

        private void selectform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

            // dataGridView1_CellClick(sender, e as DataGridViewCellEventArgs);
            nextproduct.Enabled = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cost = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            var manufact = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            var model = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            displaytext.Text = cost + "" + manufact + "" + model;
            nextproduct.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.product.Show();
            this.Hide();
        }
    }
}
