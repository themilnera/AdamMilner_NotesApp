using System;
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
    public partial class Form2 : Form
    {
        public string displayedText = "";
        public string displayedTitle = "";
        public Form2(string displayedText, string displayedTitle)
        {
            InitializeComponent();
            this.displayedText = displayedText;
            this.displayedTitle = displayedTitle;
            txtTitle2.Text = displayedTitle;
            txtField2.Text = displayedText;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
