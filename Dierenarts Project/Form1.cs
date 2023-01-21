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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtWachtwoord.PasswordChar = '•';
            txtWachtwoord.MaxLength = 20;
        }

        private void txtWachtwoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            int t = 0;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\inlogsysteem.accdb ";
            con.Open();
            OleDbDataReader dbread = null;

            string sql = "SELECT * FROM inlog WHERE gebruikersnaam = " +
                "@gebruikersnaam AND wachtwoord = @wachtwoord";
            OleDbCommand dbcom = new OleDbCommand(sql, con);

            OleDbParameter param1 = new OleDbParameter();
            param1.ParameterName = "@gebruikersnaam";
            param1.Value = txtGebruikersnaam.Text;

            OleDbParameter param2 = new OleDbParameter();
            param2.ParameterName = "@wachtwoord";
            param2.Value = txtWachtwoord.Text;

            dbcom.Parameters.Add(param1);
            dbcom.Parameters.Add(param2);

            dbread = dbcom.ExecuteReader();

            while (dbread.Read())
            {
                t++;
            }
            if (dbread.HasRows)
            {
                MessageBox.Show("ingelogd");
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("niet ingelogd");
            }

        }
    }
}
