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
            using(masterEntities db = new masterEntities())
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
        }
    }
}
