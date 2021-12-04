using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankOfTime.Models;

namespace BankOfTime
{
    public partial class Dashboard : Form
    {
        string currentUser = "654131918";
        public Dashboard()
        {
            InitializeComponent();
        }

        private string GetMobilePhone()
        {
            try
            {
                return usersDashboard.Rows[usersDashboard.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                return null;
            }
        }
        private int? GetPetitionId(string phoneNumber)
        {
            try
            {
                int? id;
               using (masterEntities db = new masterEntities())
                {
                    id = (from d in db.petition
                              where d.Performer == phoneNumber && d.Status != (int?)PetitionStatus.status.finished && d.Status != (int?)PetitionStatus.status.canceled
                              select (int?)d.Id).FirstOrDefault<int?>();

                    if (id == null)
                    {
                        petition p = new petition();
                        p.Performer = phoneNumber;
                        p.Requester = currentUser;
                        p.Status = (int?)PetitionStatus.status.pending;

                        db.petition.Add(p);
                        db.SaveChanges();

                        return p.Id;
                    }
                }
                return id;

            }
            catch
            {
                Debug.WriteLine("ERROR RETRIEVING PETITION");
                return null;
            }
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            using (masterEntities db = new masterEntities())
            {
                var lst = from d in db.user
                          select new { d.MobilePhone, d.Name, d.MonthlyHours, d.Capabilities };
                usersDashboard.DataSource = lst.ToList();
               // usersDashboard.Columns[0].Visible = false;

            }

       
        }

        private void usersDashboard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string phoneNumber = GetMobilePhone();
            if(phoneNumber != null) { 
            int? petitionId = GetPetitionId(phoneNumber);

                if(petitionId != null) { 
                    Messages messagesForm = new Messages(phoneNumber,currentUser, petitionId);
                    messagesForm.Show();
                }

            }
        }
    }
}
