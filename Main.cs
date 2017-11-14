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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_smsDataSet2.New_M' table. You can move, or remove it, as needed.
            //this.New_MTableAdapter.Fill(this.db_smsDataSet2.New_M);

        }

        private void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_M nm = new New_M();
            nm.ShowDialog();

        }
        
        private void ارسالپیامکوتاهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void تنظیماتToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            Tanzimat_email nm2 = new Tanzimat_email();
            nm2.ShowDialog();


        }

        private void گروهیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nm2 = new Form1();
            nm2.ShowDialog();
        }

        private void تکنفرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Email nm2 = new Form_Email();
            nm2.ShowDialog();
        }


 


    }
}
