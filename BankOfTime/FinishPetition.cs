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
    public partial class FinishPetition : Form
    {
        masterEntities db;
        int petitionId;
        string user;
        string target;
        public FinishPetition(int petitionId, string user, string target)
        {
            InitializeComponent();
            this.petitionId = petitionId;
            this.user = user;
            this.target = target;
        }

        private void BoxComlplain_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxComplain.Checked) txtComplain.Visible = true;
            else txtComplain.Visible = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            PetitionStatus.status status = PetitionStatus.status.finished;

            if (!boxFinished.Checked) status = PetitionStatus.status.canceled;

            finishPetition(petitionId, status);

            if(BoxComplain.Checked && !string.IsNullOrEmpty(txtComplain.Text))
            {
                createComplain(petitionId, txtComplain.Text);
            }

            this.DialogResult = DialogResult.OK;

            this.Close();

        }

        public void finishPetition(int petitionId, PetitionStatus.status status)
        {
            if (db == null || Helper.Helper.IsDisposed(db))
                db = new masterEntities();

            petition p = db.petition.Find(petitionId);

            p.Id = petitionId;
            p.Status = (int?)status;

            p.user.Balance = p.user.Balance + p.HoursTransferred;

            db.SaveChanges();

            db.Dispose();
        }

        public void createComplain(int petitionId, string message)
        {
            if (db == null || Helper.Helper.IsDisposed(db))
                db = new masterEntities();

            complain c = new complain();
            c.Date = DateTime.Now;
            c.Message = message;
            c.Issuer = user;
            c.User = target;

            db.complain.Add(c);

            db.SaveChanges();
            db.Dispose();

        }
    }
}
