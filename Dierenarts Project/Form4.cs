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
    public partial class Form4 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form4()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    data source = ..\\..\\..\\Dierenarts_royal.accdb ; Persist Security Info=False;";

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void btnVoeg_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Klant (voornaam, achternaam, adres, woonplaats) values('"+ txtVoornaam.Text + "','" + txtAchternaam.Text + "','" + txtAdres.Text + "','" + txtWoonplaats.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Data succesvol toegevoegd.");
                connection.Close();
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
    }
}
