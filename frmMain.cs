using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace splahScreen_and_Login
{
    public partial class frmMain : Form
    {
        SqlConnection UserConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\ikhela.mdf;Integrated Security=True;Connect Timeout=30");

        public frmMain()
        {
            InitializeComponent();
        }
        private void SignUp_Click(object sender, EventArgs e)

        {
            if (TxtUser.Text == "" || TxtMail.Text == "" || TxtPassword.Text == "" || TxtPasswordTwo.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires !", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPassword.Text  != TxtPasswordTwo.Text)
            {
                MessageBox.Show("Mot de passe non identique", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UserConn.State != ConnectionState.Open)
                {
                    try
                    {
                        UserConn.Open();

                        // Si l'utilisateur existe renvoyé lui un message. 

                        String checkedUserAndEmail = "SELECT COUNT(*) FROM Users WHERE (full_name =@user) OR (email =@email)" ;
                    
                        using (SqlCommand cmdChecked = new SqlCommand(checkedUserAndEmail, UserConn))
                        {
                            cmdChecked.Parameters.AddWithValue("@user", TxtUser.Text.Trim());
                            cmdChecked.Parameters.AddWithValue("@email", TxtMail.Text.Trim());

                            //convertie explicitement en integer.
                            int countUser = (int)cmdChecked.ExecuteScalar();
                            int countEmail = (int)cmdChecked.ExecuteScalar();

                            if (countUser > 1 )
                            {
                                MessageBox.Show(TxtUser + " existe déjà!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (countEmail > 1)
                            {
                                MessageBox.Show(TxtMail + " existe déjà!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                String InsertUser = "INSERT INTO Users (full_name,email,password) VALUES (@user, @email, @password)";
                                using (SqlCommand cmdInsert = new SqlCommand(InsertUser, UserConn))
                                {
                                    cmdInsert.Parameters.AddWithValue("@user", TxtUser.Text.Trim());
                                    cmdInsert.Parameters.AddWithValue("@email", TxtMail.Text.Trim());
                                    cmdInsert.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
                                    cmdInsert.ExecuteNonQuery();
                                    MessageBox.Show("Inscription réussie", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } ; 
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message,"SIGN UP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        UserConn.Close();
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
