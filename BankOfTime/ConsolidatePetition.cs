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
    public partial class ConsolidatePetition : Form
    {
        int petitionId;
        public ConsolidatePetition(int petitionId)
        {
            InitializeComponent();

            this.petitionId = petitionId;
        }

        private void btnConsolidate_Click(object sender, EventArgs e)
        {

            
            
            borrarMensajesError();
            if (validarCampos())
            {
                using (masterEntities db = new masterEntities())
                {
                    petition p = db.petition.Find(petitionId);
                    p.Id = petitionId;
                    p.Details = txtDetails.Text;
                    p.Date = dt_datapeticio.Value;
                    p.HoursTransferred = int.Parse(txtPetitionHours.Text);

                    db.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }

                MessageBox.Show("Petición guardada correctamente!", "Petición", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Petición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private bool validarCampos()
        {
            bool ok = true;

            if (txtDetails.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDetails, "Debe ingresar los detalles");
            }

            if (txtPetitionHours.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPetitionHours, "Debe ingresar el número de horas");
            }

            return ok;
        }

        private void borrarMensajesError()
        {
            errorProvider1.SetError(txtDetails, "");
            errorProvider1.SetError(txtPetitionHours, "");
        }
    }
}
