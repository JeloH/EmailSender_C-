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
    public partial class Form1 : Form
    {
        Class_mft c1 = new Class_mft();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                c1.SendMessage("hjelovdar@gmail.com", listBox1.Items[i].ToString(), Subjectxt3.Text, Messagetxt4.Text, "hjelovdar", "!1#3(9@2", Attachtxt5.Text);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Resivtxt2.Text);
            Resivtxt2.Text = "";

        }
    }
}
