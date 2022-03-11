using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3___Chapter_Problem
{
    public partial class Chapter3Assignment : Form
    {
        
        public Chapter3Assignment()
        {

            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        
        
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(nudAge.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            lblOutput.Text = ($"Hi, {name} You are {age} and are {height} centimetres tall");

        }

        private void lbl_Click(object sender, EventArgs e)
        {
        }
    }
}
