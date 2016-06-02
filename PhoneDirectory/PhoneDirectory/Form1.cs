using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PhoneDirectory
{
    public partial class Form1 : Form
    {
        OleDbConnection connect = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Guest\Documents\Visual Studio 2010\Projects\PhoneDirectory\PhoneInfo.accdb;
Persist Security Info=False;";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "insert into Phone (FirstName,LastName,MobileNo,EmailId) values('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_mobile.Text + "','" + txt_email.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query="delete from Phone where FirstName='"+txt_fname.Text+"'";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query = "update Phone set FirstName='"+txt_fname.Text+"' ,LastName='"+txt_lname.Text+"' ,MobileNo='"+txt_mobile.Text+"' ,EmailId='"+txt_email.Text+"' where FirstName='"+txt_fname.Text+"'";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query = "select * from Phone";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Data Loaded");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        
    }
}
