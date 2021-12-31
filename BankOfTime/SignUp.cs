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
            
            
                borrarIconomensajes();
                if (validarCampos())
                {
                    
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



                    using (masterEntities db = new masterEntities())
                    {
                        db.user.Add(userToCreate);
                        db.SaveChanges();


                    }

                    this.Close();

                    MessageBox.Show("Usuario creado correcatmente", "Registro Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error en los campos", "Todos los campos son obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            





        }
        private bool validarCampos()
        {
            bool ok = true;

            if(txtName.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtName, "Debe ingresar el nombre");
            }

            if (txtMonthlyHours.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMonthlyHours, "Debe ingresar el número de horas al mes");
            }

            if (txtPhoneNumber.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPhoneNumber, "Debe ingresar el número de teléfono");
            }

            if (txtCapabilities.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCapabilities, "Debe ingresar sus habilidades");
            }
            if (txtPassword.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPassword, "Debe ingresar el password");
            }

            return ok;
        }

        private void borrarIconomensajes()
        {
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(txtMonthlyHours, "");
            errorProvider1.SetError(txtPhoneNumber, "");
            errorProvider1.SetError(txtCapabilities, "");
            errorProvider1.SetError(txtPassword, "");
        }
    }

    
}
