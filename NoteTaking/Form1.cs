﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 240;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();

        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if(index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2(txtTitle.Text, txtMessage.Text);
            secondForm.Show();
        }
    }
}
