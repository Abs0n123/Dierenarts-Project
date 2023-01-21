using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierenarts_Project
{
    public partial class Form3 : Form
    {
        
        private OleDbConnection connection = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    data source = ..\\..\\..\\Dierenarts_royal.accdb ; Persist Security Info=False;";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close(); form2.Show();
        }


        private void btnToevoegen_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Klant"; 
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    lbxKlanten.Items.Add(reader["voornaam"]);
                }


                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }

           
        }

        //private void cbxKlant_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        connection.Open();
        //        OleDbCommand command = new OleDbCommand();
        //        command.Connection = connection;
        //        string query = "select * from Klant where voornaam = '" + lbxKlanten.SelectedItem + "'";
        //        command.CommandText = query;

        //        OleDbDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            txtVoornaam.Text   = reader["voornaam"].ToString();
        //            txtAchternaam.Text = reader["achternaam"].ToString();
        //            txtAdres.Text      = reader["adres"].ToString();
        //            txtWoonplaats.Text = reader["woonplaats"].ToString();

        //        }


        //        connection.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error  " + ex);
        //    }
        //}

        private void txtWijzigen_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void lbxKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Klant where voornaam = '" + lbxKlanten.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtId.Text = reader["Id"].ToString();
                    txtVoornaam.Text = reader["voornaam"].ToString();
                    txtAchternaam.Text = reader["achternaam"].ToString();
                    txtAdres.Text = reader["adres"].ToString();
                    txtWoonplaats.Text = reader["woonplaats"].ToString();

                }


                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
            try
            {
                lbxHandelingen.Items.Clear();
                Globaal.Connection.Open();
                OleDbConnection con = new OleDbConnection();
                string sql = "select * from Handeling where klantId = @klantid";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                dbcom.Parameters.AddWithValue("@klantid", txtId.Text);
                OleDbDataReader reader = dbcom.ExecuteReader();
                while (reader.Read())
                {
                    lbxHandelingen.Items.Add(reader["handeling"]);
                }


                Globaal.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }

            try
            {
                txtHandeling.Text = null;
                string aantal = lbxHandelingen.Items.Count.ToString();
                txtHandeling.Text = aantal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void lbxHandelingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
