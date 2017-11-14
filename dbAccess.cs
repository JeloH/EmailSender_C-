using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;


using System.IO;

 
using System.Windows.Forms;


namespace WindowsFormsApplication11_Part_SMS
{
    class dbAccess
    {
        
     public   OleDbCommand cmd;
     public OleDbConnection con;
     public OleDbDataAdapter da;
     public DataView dv;
     public DataSet ds;

        private static string cmdAccess5;

        public static string CmdAccess5
        {
            get { return dbAccess.cmdAccess5; }
            set { dbAccess.cmdAccess5 = value; }
        }





        public static void CallDB(string strCodeSql)
        {

            OleDbConnection con = new OleDbConnection();
            
            try
            {
               
              //  string s3 = "Data Source=.;Initial Catalog=db2;Integrated Security=true;";
                //string s3 = @"provider=microsoft.jet.oledb.4.0;" + @"data source=..\\Debug\\db\\db2.mdb";


                string str1 = "";
               str1 = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Directory.GetCurrentDirectory() + "\\db\\db_sms.mdb"; 
                con = new OleDbConnection(str1);



                OleDbCommand cmd = new OleDbCommand(strCodeSql, con);
                con.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception er)
            {
                 MessageBox.Show(er.Message);



            }
            finally
            {
                con.Close();

            }

            
        }


            DataTable dt;

        public DataTable MySelect(string sql)
        {
            con = new OleDbConnection();
            con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=..\\Debug\\db\\db2.mdb;";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            da = new OleDbDataAdapter(cmd);
            dt = new DataTable();

            con.Open();
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }


        

       



        public DataView vt (string strd){
        
            
            string str1 = "";
           str1 = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Directory.GetCurrentDirectory() + "\\db\\db_sms.mdb"; 
            con = new OleDbConnection(str1);
            OleDbCommand com = con.CreateCommand();
            com.CommandText = strd;
            com.CommandType = CommandType.Text;

            ds = new DataSet();

            da = new OleDbDataAdapter(com);

            OleDbCommandBuilder comb = new OleDbCommandBuilder(da);

            da.Fill(ds);
            dv = new DataView(ds.Tables[0]);

            return dv;
    }




    }
}