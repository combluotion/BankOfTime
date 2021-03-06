using BankOfTime.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankOfTime
{
    public partial class Login : Form
    {
        masterEntities db;
        public Login()
        {
            InitializeComponent();
        }

        public Login(masterEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtPhoneNumber.Text;
                string password = txtPassword.Text;
                bool loginOK = false;

                using (masterEntities db = new masterEntities())
                {
                    var userLogin = (from d in db.user
                                     where d.MobilePhone == user && d.Password == password
                                     select new { d.MobilePhone }).FirstOrDefault();

                    if (userLogin != null)
                    {
                        loginOK = true;
                    }

                }

                if (loginOK)
                {
                    Dashboard dashboardForm = new Dashboard(user);

                    this.Hide();
                    dashboardForm.Closed += (s, args) => this.Close();
                    dashboardForm.Show();
                }
                else
                {
                    // Displays the MessageBox.
                    MessageBox.Show("Wrong user or password!", "Please enter your user and password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                //System.Data.Entity.Infrastructure.DbUpdateException
                if(ex.Number == 2627)
                {
                    MessageBox.Show("El usuario ya seencuentra en la base de datos", "Erro Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                
            }




        }

        public bool TryLogin(string user, string password)
        {
            bool loginResponse = false;



            if (db == null || Helper.Helper.IsDisposed(db))
                db = new masterEntities();

                var userLogin = (from d in db.user
                                 where d.MobilePhone == user && d.Password == password
                                 select new { d.MobilePhone }).FirstOrDefault();

                if (userLogin != null)
                {
                    loginResponse = true;
                }

            db.Dispose();

            

            return loginResponse;
        }


    }
}
