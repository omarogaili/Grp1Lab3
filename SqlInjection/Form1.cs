using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace SqlInjection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UserValidation userValidation = new UserValidation();
        private void Inloggning()
        {
            string server = "localhost";
            string database = "********";
            string dbUser = "root";
            string dbPass = "*********";
            string connString = $"SERVER={server};DATABASE={database};UID={dbUser};PASSWORD={dbPass};";
            MySqlConnection conn = new MySqlConnection(connString);
            // Hämta data från textfält
            string user = txtUser.Text;
            string pass = txtPass.Text;
            // Validera att användarnamnet är en e-postadress eller telefonnummer
            if (!userValidation.IsValidEmail(user) && !userValidation.IsValidPhoneNumber(user))
            {
                lblStatus.Text = "Användarnamnet måste vara en giltig e-postadress eller telefonnummer.";
                return;
            }
            // Bygg upp SQL-query utan hashning
            string sqlQuery = "SELECT * FROM users WHERE users_username = @user AND users_password = @pass";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass); // Använd lösenord direkt, utan hashning
            lblQuerry.Text = sqlQuery;
            // Exekvera query
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                // Kontrollera resultatet
                if (reader.Read())
                    lblStatus.Text = "Du har loggat in";
                else
                    lblStatus.Text = "Du är utloggad";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}