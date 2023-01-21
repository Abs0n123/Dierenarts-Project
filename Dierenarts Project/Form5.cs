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
    public partial class Form5 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form5()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    data source = ..\\..\\..\\Dierenarts_royal.accdb ; Persist Security Info=False;";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            try
            {

                Globaal.Connection.Open();
                OleDbCommand con = new OleDbCommand();
                con.Connection = connection;
                string sql = "UPDATE Klant set voornaam= @voornaam, achternaam= @achternaam, adres = @adres, woonplaats= @woonplaats where Id= @id";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                dbcom.Parameters.AddWithValue("@voornaam", txtVoornaam.Text);
                dbcom.Parameters.AddWithValue("@achternaam", txtAchternaam.Text);
                dbcom.Parameters.AddWithValue("@adres", txtAdres.Text);
                dbcom.Parameters.AddWithValue("@woonplaats", txtWoonplaats.Text);
                dbcom.Parameters.AddWithValue("@id", txtId.Text);
                dbcom.ExecuteNonQuery();
                dbcom.Dispose();
                MessageBox.Show("Data succesvol toegevoegd.");
                Globaal.Connection.Close();
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void cmbNaam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Klant where voornaam = '" + cmbNaam.Text + "'";
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
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Klant";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbNaam.Items.Add(reader["voornaam"]);
                }


                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            string sql = "delete from Klant where Id = @klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@klantid", txtId.Text);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Verwijderd");
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
