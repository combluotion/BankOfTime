using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankOfTime.Models;
namespace BankOfTime
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Obtain values
            string nameTxt = txtName.Text;
            int monthlyHoursVal = int.Parse(txtMonthlyHours.Text);
            string phoneNumberTxt = txtPhoneNumber.Text;
            string capabilitiesTxt = txtCapabilities.Text;
            string passwordTxt = txtPassword.Text;

            user userToCreate = new user();
            userToCreate.Name = nameTxt;
            userToCreate.MonthlyHours = monthlyHoursVal;
            userToCreate.Balance = monthlyHoursVal;
            userToCreate.MobilePhone = phoneNumberTxt;
            userToCreate.Capabilities = capabilitiesTxt;
            userToCreate.Password = passwordTxt;

            using(masterEntities db = new masterEntities())
            {
                db.user.Add(userToCreate);
                db.SaveChanges();
                

            }

            this.Close();
        }
    }
}
