using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication11_Part_SMS
{
    public partial class Form_Email : Form
    {

        Class_mft c1 = new Class_mft();


        Tanzimat_email tem2;
        
        public static string G_mail;
        public static string G_user;
        public static string G_pass;
      

        public Form_Email()
        {
            InitializeComponent();
            Sendertxt1.Text = G_mail;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);           
        

        }


        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopenFile = new OpenFileDialog();
            dlgopenFile.Filter = "All Files (*.*)|*.*";

             dlgopenFile.Title = "Select File to Attach";
			
            dlgopenFile.ShowDialog();
            Attachtxt5.Text = dlgopenFile.FileName;
           // listBox1.Items.Add(textBox5.Text);
	
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Send();
            //  c1.SendMessage2(textBox1.Text, textBox2.Text, textBox3.Text, "text1", "hajelovdar", "136913691369", textBox5.Text);

          
            backgroundWorker1.RunWorkerAsync();       
        }



        private void label11_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            tem2 = new Tanzimat_email();
            tem2.ShowDialog();
     
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            c1.SendMessage("name_sender", Resivtxt2.Text, Subjectxt3.Text, Messagetxt4.Text, G_user, G_pass, Attachtxt5.Text);

            }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = String.Format("Result = {0}", e.Result.ToString());
                MessageBox.Show(msg);
                MessageBox.Show("ersal shod");
        
            } 
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Text = e.ProgressPercentage.ToString(); 
           // this.progressBar1.Value = e.ProgressPercentage;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }




        }


               }
    

