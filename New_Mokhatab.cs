using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

 using System.Data.OleDb;
using System.Configuration;
using System.IO;


namespace WindowsFormsApplication11_Part_SMS
{



 
      

    public partial class New_M : Form
    {



        public OleDbConnection con;
        public OleDbDataAdapter da;


        public New_M()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = "";
          
      str1 = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Directory.GetCurrentDirectory() + "\\db\\db_sms.mdb"; 

            str1 = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Directory.GetCurrentDirectory() + "\\db\\db_sms.mdb"; 
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Directory.GetCurrentDirectory() + "\\db\\db_sms.mdb"); 

            con.Open();
            //جلوگیری از تکرار کد_ملی
            string s1 = "select شماره_همراه from New_M where شماره_همراه='" + textBox3.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(s1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {


                OleDbConnection CN = new OleDbConnection(str1);

                string qry = "insert into New_M(نام,فامیلی,شماره_همراه,رایان_نامه,توضیحات) values(@c1,@c2,@c3,@c4,@c5)";

                    //  byte[] imageData = Class_mft.ReadFile(label6.Text);

                   // textBox3.Text= Convert.ToString(int.Parse(textBox3.Text));

                    OleDbCommand SqlCom = new OleDbCommand(qry, CN);

                    SqlCom.Parameters.Add(new OleDbParameter("@c1", (object)textBox1.Text));
                    SqlCom.Parameters.Add(new OleDbParameter("@c2", (object)textBox2.Text));
                    SqlCom.Parameters.Add(new OleDbParameter("@c3", (object)textBox3.Text));
                    SqlCom.Parameters.Add(new OleDbParameter("@c4", (object)textBox4.Text));
                    SqlCom.Parameters.Add(new OleDbParameter("@c5", (object)textBox5.Text));
                    //    SqlCom.Parameters.Add(new SqlParameter("@c2", (object)textBox4.Text));

                    //SqlCom.Parameters.Add(new SqlParameter("@c3", (object)imageData));

                    CN.Open();

                    SqlCom.ExecuteNonQuery();

                    CN.Close();


                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                 

                
               
                  
            }

            else { 
                MessageBox.Show("این شماره شماره_همراه ثبت شده است");
            }
        }

        private void New_M_Load(object sender, EventArgs e)
        {

        }
    }
}
