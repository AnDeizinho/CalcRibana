using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsumoRibana
{
    public partial class Form1 : Form
    {
        List<Ribana> lista;
        public Form1()
        {
            lista = new List<Ribana>();
            InitializeComponent();
            dataGridView1.Columns["kilos"].DefaultCellStyle.Format = "0.0000";
            dataGridView1.Columns["compr"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["larg"].DefaultCellStyle.Format = "0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                Ribana rib = new Ribana(int.Parse(txtqtd.Text),( double.Parse(txtgram.Text)/1000), double.Parse(txtlarg.Text));
                lista.Add(rib);
                dataGridView1.DataSource = lista;
            }
            catch
            {
                MessageBox.Show("Digite somente números");
                limapr();
            }
        }
        void limapr()
        {
            txtgram.Text = "0";
            txtqtd.Text = "0";
        }
        
    }
}
