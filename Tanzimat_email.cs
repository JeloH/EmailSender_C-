using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11_Part_SMS
{
    public partial class Tanzimat_email : Form
    {



        

        public Tanzimat_email()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        Form_Email f;
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Email.G_user = textBox1.Text;
            Form_Email.G_pass = textBox2.Text;
            Form_Email.G_mail = textBox3.Text;
            f = new Form_Email();
            f.Sendertxt1.Text = textBox3.Text;
            f.Sendertxt1.Enabled = false;
            f.Visible=true;
            this.Close();
         
        }

        private void Tanzimat_email_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_smsDataSet1.New_M' table. You can move, or remove it, as needed.
      

        }
    }
}
