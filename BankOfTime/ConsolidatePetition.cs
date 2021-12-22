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

            bool consolidated = ConsolidatePetitionCall(petitionId, txtDetails.Text, dt_datapeticio.Value, int.Parse(txtPetitionHours.Text));

            if (consolidated)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Abort;

            this.Close();

        }

        public bool ConsolidatePetitionCall(int petitionId,string details, DateTime dataPeticio, int hoursTransferred)
        {

            if (db == null)
                db = new masterEntities();

            petition p = db.petition.Find(petitionId);

            if (p.user1.Balance < hoursTransferred)
                return false;

            p.Id = petitionId;
            p.Details = details;
            p.Date = dataPeticio;
            p.HoursTransferred = hoursTransferred;

            p.user1.Balance = p.user1.Balance - hoursTransferred;

            db.SaveChanges();

            db.Dispose();

            return true;
        }

        }
    }

