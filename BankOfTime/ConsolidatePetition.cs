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
        masterEntities db;
        int petitionId;
        public ConsolidatePetition(int petitionId)
        {
            InitializeComponent();

            this.petitionId = petitionId;
        }

        public ConsolidatePetition(int petitionId, masterEntities db)
        {
            InitializeComponent();

            this.petitionId = petitionId;
            this.db = db;
        }

        private void btnConsolidate_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                bool consolidated = ConsolidatePetitionCall(petitionId, txtDetails.Text, dt_datapeticio.Value, int.Parse(txtPetitionHours.Text));

                if (consolidated)
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.Abort;
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Petición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }

        public bool ConsolidatePetitionCall(int petitionId,string details, DateTime dataPeticio, int hoursTransferred)
        {
            borrarMensajesError();
            if (db == null || Helper.Helper.IsDisposed(db))
                db = new masterEntities();

            petition p = db.petition.Find(petitionId);

            if (p.user1.Balance < hoursTransferred)
                return false;

            
                p.Id = petitionId;
            p.Details = details;
            p.Date = dataPeticio;
            p.HoursTransferred = hoursTransferred;
            p.Status = (int?)PetitionStatus.status.onGoing;

            p.user1.Balance = p.user1.Balance - hoursTransferred;

            db.SaveChanges();

            db.Dispose();

            
           

           MessageBox.Show("Petición guardada correctamente!", "Petición", MessageBoxButtons.OK, MessageBoxIcon.Information);

            


            return true;
            

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

