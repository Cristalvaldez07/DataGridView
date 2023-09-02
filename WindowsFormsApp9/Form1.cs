using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private decimal totalDebito = 0;
        private decimal totalCredito = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           



        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cuenta = textBox1.Text;
            string nombre = textBox2.Text;
            string tipo = comboBox1.Text;
            decimal monto = decimal.Parse(textBox3.Text);

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[0].Value = cuenta;
            row.Cells[1].Value = nombre;

            if (tipo == "Débito")
            {
                row.Cells[2].Value = monto;
            }
            else if (tipo == "Crédito")
            {
                row.Cells[3].Value = monto;
            }

            dataGridView1.Rows.Add(row);

            textBox5.Text = totalDebito.ToString();
            textBox4.Text = totalCredito.ToString();

        }


       
        

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            



        }

        private void label1_Click(object sender, EventArgs e)
        {






        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }
    }
}



